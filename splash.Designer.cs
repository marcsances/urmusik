﻿namespace fPlayer_2
{
    partial class splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.taskLabels = new Label2();
            this.curTask = new Label2();
            this.SuspendLayout();
            // 
            // taskLabels
            // 
            resources.ApplyResources(this.taskLabels, "taskLabels");
            this.taskLabels.BackColor = System.Drawing.Color.Transparent;
            this.taskLabels.ForeColor = System.Drawing.Color.Black;
            this.taskLabels.Name = "taskLabels";
            this.taskLabels.Tag = "";
            // 
            // curTask
            // 
            resources.ApplyResources(this.curTask, "curTask");
            this.curTask.BackColor = System.Drawing.Color.Transparent;
            this.curTask.ForeColor = System.Drawing.Color.Black;
            this.curTask.Name = "curTask";
            this.curTask.Tag = "Carregant biblioteques...!Carregant cançons...!Llest...";
            // 
            // splash
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.taskLabels);
            this.Controls.Add(this.curTask);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        public Label2 curTask;
        public Label2 taskLabels;
    }
}