namespace kapigi
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.btnKapiAc = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grupKamera = new System.Windows.Forms.GroupBox();
            this.grupButons = new System.Windows.Forms.GroupBox();
            this.txtFeed = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.grupKamera.SuspendLayout();
            this.grupButons.SuspendLayout();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlcControl1.Location = new System.Drawing.Point(3, 16);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(639, 407);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 3;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = null;
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // btnKapiAc
            // 
            this.btnKapiAc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapiAc.Location = new System.Drawing.Point(189, 6);
            this.btnKapiAc.Name = "btnKapiAc";
            this.btnKapiAc.Size = new System.Drawing.Size(280, 34);
            this.btnKapiAc.TabIndex = 7;
            this.btnKapiAc.Text = "KAPIYI AÇ";
            this.btnKapiAc.UseVisualStyleBackColor = true;
            this.btnKapiAc.Click += new System.EventHandler(this.btnKapiAc_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.Location = new System.Drawing.Point(94, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 34);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlay.Location = new System.Drawing.Point(13, 7);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 34);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // grupKamera
            // 
            this.grupKamera.Controls.Add(this.vlcControl1);
            this.grupKamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grupKamera.Location = new System.Drawing.Point(0, 71);
            this.grupKamera.Name = "grupKamera";
            this.grupKamera.Size = new System.Drawing.Size(645, 426);
            this.grupKamera.TabIndex = 8;
            this.grupKamera.TabStop = false;
            // 
            // grupButons
            // 
            this.grupButons.Controls.Add(this.txtStatus);
            this.grupButons.Controls.Add(this.txtFeed);
            this.grupButons.Controls.Add(this.btnPlay);
            this.grupButons.Controls.Add(this.btnStop);
            this.grupButons.Controls.Add(this.btnKapiAc);
            this.grupButons.Dock = System.Windows.Forms.DockStyle.Top;
            this.grupButons.Location = new System.Drawing.Point(0, 0);
            this.grupButons.Name = "grupButons";
            this.grupButons.Size = new System.Drawing.Size(645, 71);
            this.grupButons.TabIndex = 9;
            this.grupButons.TabStop = false;
            // 
            // txtFeed
            // 
            this.txtFeed.Location = new System.Drawing.Point(13, 48);
            this.txtFeed.Name = "txtFeed";
            this.txtFeed.Size = new System.Drawing.Size(456, 20);
            this.txtFeed.TabIndex = 8;
            this.txtFeed.Text = "rtsp://***:***@10.***:554//Streaming/Channels/1";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(475, 8);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(167, 61);
            this.txtStatus.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 497);
            this.Controls.Add(this.grupKamera);
            this.Controls.Add(this.grupButons);
            this.MinimumSize = new System.Drawing.Size(493, 463);
            this.Name = "Main";
            this.Text = "Kapıcı";
            this.Load += new System.EventHandler(this.Main_Load);
            //((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.grupKamera.ResumeLayout(false);
            this.grupButons.ResumeLayout(false);
            this.grupButons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Button btnKapiAc;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox grupKamera;
        private System.Windows.Forms.GroupBox grupButons;
        private System.Windows.Forms.TextBox txtFeed;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

