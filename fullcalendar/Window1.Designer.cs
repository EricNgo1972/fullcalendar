namespace fullcalendar
{
	partial class Window1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.fullCalendar1 = new Wisej.Web.Ext.FullCalendar.FullCalendar();
            this.SuspendLayout();
            // 
            // fullCalendar1
            // 
            this.fullCalendar1.Dock = Wisej.Web.DockStyle.Fill;
            this.fullCalendar1.Name = "fullCalendar1";
            this.fullCalendar1.Size = new System.Drawing.Size(1111, 765);
            this.fullCalendar1.TabIndex = 0;
            this.fullCalendar1.Text = "fullCalendar1";
            this.fullCalendar1.View = Wisej.Web.Ext.FullCalendar.ViewType.AgendaDay;
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1111, 765);
            this.Controls.Add(this.fullCalendar1);
            this.Name = "Window1";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

        #endregion

        private Wisej.Web.Ext.FullCalendar.FullCalendar fullCalendar1;
    }
}

