using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace kapigi
{
    public partial class Main : Form
    {
        private delegate void delege();

        public Main()
        {
            InitializeComponent();

            try
            {
                DLLyukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            vlcControl1.SetMedia(txtFeed.Text);
            vlcControl1.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.FormClosing += Main_FormClosing;

            try
            {
                vlcControl1.VlcLibDirectoryNeeded += new EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(CheckVlcDir);
                vlcControl1.EndInit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            vlcControl1.Stop();
        }

        private void CheckVlcDir(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            string aP = null;

            if (Environment.Is64BitOperatingSystem)
            {
                aP = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "VideoLAN\\VLC");
            }
            else
            {
                aP = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "VideoLAN\\VLC");
            }
            if (!File.Exists(Path.Combine(aP, "libvlc.dll")))
            {
                using (FolderBrowserDialog fbdDialog = new FolderBrowserDialog())
                {
                    fbdDialog.Description = "Select VLC Path";
                    fbdDialog.SelectedPath = Path.Combine(aP, "VideoLAN\\VLC");

                    if (fbdDialog.ShowDialog() == DialogResult.OK)
                    {
                        e.VlcLibDirectory = new DirectoryInfo(fbdDialog.SelectedPath);
                    }
                }
            }
            else
            {
                e.VlcLibDirectory = new DirectoryInfo(aP);
            }
        }

        private void btnKapiAc_Click(object sender, EventArgs e)
        {
            Thread kapiAcThread = new Thread(new ThreadStart(KapiAc));
            kapiAcThread.Start();
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int BS_InitSDK();

        private void DLLyukle()
        {
            IntPtr pDll = NativeMethods.LoadLibrary("BS_SDK.dll");
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "BS_InitSDK");

            BS_InitSDK bs_initSDK = (BS_InitSDK)Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall,typeof(BS_InitSDK));

            int theResult = bs_initSDK();
            bool result = NativeMethods.FreeLibrary(pDll);

            MessageBox.Show(Convert.ToString(theResult));
        }

        private void KapiAc()
        {
            string addr = "10.5.5.26";

            int handle = 0;

            int result = BSSDK.BS_OpenSocket(addr.ToString(), 1471, ref handle);
            if (result != BSSDK.BS_SUCCESS)
            {
                this.BeginInvoke(new delege(() =>
                {
                    txtStatus.AppendText("Cihaza bağlanılamadı. Bağlantıda sorun veya aktif bir bağlantı olabilir.");
                }
                ));
                return;
            }

            uint deviceId = 0;
            int deviceType = 0;
            result = BSSDK.BS_GetDeviceID(handle, ref deviceId, ref deviceType);

            if (result != BSSDK.BS_SUCCESS)
            {
                this.BeginInvoke(new delege(() =>
                {
                    txtStatus.AppendText("Cihaz ID si alınamadı.");
                }
                ));
            }
            // Set the ID and the type of the device for further commands
            BSSDK.BS_SetDeviceID(handle, deviceId, deviceType);

            result = BSSDK.BS_DoorControl(handle, 0, true);
            if (result != BSSDK.BS_SUCCESS)
            {
                this.BeginInvoke(new delege(() =>
                {
                    txtStatus.AppendText("Kapı açılamadı.");
                }
                ));
            }

            System.Threading.Thread.Sleep(3000);
            result = BSSDK.BS_DoorControl(handle, 0, false);

            if (result != BSSDK.BS_SUCCESS)
            {
                this.BeginInvoke(new delege(() =>
                {
                    txtStatus.AppendText("Kapı kapatılamadı.");
                }
                ));
            }

            result = BSSDK.BS_CloseSocket(handle);


            if (result != BSSDK.BS_SUCCESS)
            {
                this.BeginInvoke(new delege(() =>
                {
                    txtStatus.AppendText("Cihaz bağlantısı kapatılamadı.");
                }
                ));
                return;
            }

            //AddConnectedDevice(m_DeviceID, m_DeviceType, m_DeviceAddr, handle);
            //0x01 =BS_DEVICE_BIOENTRY_PLUS
            //0x00 =BS_DEVICE_BIOSTATION
            /*
            var dialog = new SaveFileDialog { Filter = "Bitmap Image|*.bmp" };
            if (dialog.ShowDialog() == true)
            {
                _streamPlayerControl.GetCurrentFrame().Save(dialog.FileName);
            }
             * */
        }
    }
}
