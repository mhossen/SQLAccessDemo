namespace FormUI
{
  partial class Dashboard
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
      this.LastNameLabel = new System.Windows.Forms.Label();
      this.LastNameText = new System.Windows.Forms.TextBox();
      this.peopleFoundListbox = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // LastNameLabel
      // 
      this.LastNameLabel.AutoSize = true;
      this.LastNameLabel.Location = new System.Drawing.Point(13, 31);
      this.LastNameLabel.Name = "LastNameLabel";
      this.LastNameLabel.Size = new System.Drawing.Size(80, 17);
      this.LastNameLabel.TabIndex = 0;
      this.LastNameLabel.Text = "Last Name:";
      // 
      // LastNameText
      // 
      this.LastNameText.Location = new System.Drawing.Point(108, 31);
      this.LastNameText.Name = "LastNameText";
      this.LastNameText.Size = new System.Drawing.Size(142, 22);
      this.LastNameText.TabIndex = 1;
      // 
      // peopleFoundListbox
      // 
      this.peopleFoundListbox.FormattingEnabled = true;
      this.peopleFoundListbox.ItemHeight = 16;
      this.peopleFoundListbox.Location = new System.Drawing.Point(16, 75);
      this.peopleFoundListbox.Name = "peopleFoundListbox";
      this.peopleFoundListbox.Size = new System.Drawing.Size(234, 244);
      this.peopleFoundListbox.TabIndex = 2;
      // 
      // Dashboard
      // 
      this.ClientSize = new System.Drawing.Size(646, 571);
      this.Controls.Add(this.peopleFoundListbox);
      this.Controls.Add(this.LastNameText);
      this.Controls.Add(this.LastNameLabel);
      this.Name = "Dashboard";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    
    private System.Windows.Forms.Label LastNameLabel;
    private System.Windows.Forms.TextBox LastNameText;
    private System.Windows.Forms.ListBox peopleFoundListbox;
  }
}

