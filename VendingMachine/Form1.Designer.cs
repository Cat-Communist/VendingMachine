namespace VendingMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtOut = new RichTextBox();
            btnRefill = new Button();
            btnGet = new Button();
            txtInfo = new RichTextBox();
            imageList = new ImageList(components);
            listView = new ListView();
            SuspendLayout();
            // 
            // txtOut
            // 
            txtOut.Location = new Point(14, 129);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(299, 299);
            txtOut.TabIndex = 0;
            txtOut.Text = "";
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(14, 12);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(563, 29);
            btnRefill.TabIndex = 1;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(485, 129);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(92, 299);
            btnGet.TabIndex = 2;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(14, 47);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(465, 76);
            txtInfo.TabIndex = 3;
            txtInfo.Text = "";
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "Comet.jpg");
            imageList.Images.SetKeyName(1, "Planet.jpg");
            imageList.Images.SetKeyName(2, "Star.jpg");
            // 
            // listView
            // 
            listView.Location = new Point(319, 129);
            listView.Name = "listView";
            listView.Size = new Size(160, 299);
            listView.SmallImageList = imageList;
            listView.TabIndex = 4;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.SmallIcon;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 446);
            Controls.Add(listView);
            Controls.Add(txtInfo);
            Controls.Add(btnGet);
            Controls.Add(btnRefill);
            Controls.Add(txtOut);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtOut;
        private Button btnRefill;
        private Button btnGet;
        private RichTextBox txtInfo;
        private ImageList imageList;
        private ListView listView;
    }
}
