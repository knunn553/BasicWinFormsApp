namespace WinFormsApp
{
    partial class Form
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
            saveButton = new Button();
            sensorNameLabel = new Label();
            sensorTypeLabel = new Label();
            sensorNameValue = new TextBox();
            sensorTypeValue = new TextBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 207);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(776, 231);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // sensorNameLabel
            // 
            sensorNameLabel.AutoSize = true;
            sensorNameLabel.Location = new Point(12, 9);
            sensorNameLabel.Name = "sensorNameLabel";
            sensorNameLabel.Size = new Size(157, 32);
            sensorNameLabel.TabIndex = 1;
            sensorNameLabel.Text = "Sensor Name";
            // 
            // sensorTypeLabel
            // 
            sensorTypeLabel.AutoSize = true;
            sensorTypeLabel.Location = new Point(12, 99);
            sensorTypeLabel.Name = "sensorTypeLabel";
            sensorTypeLabel.Size = new Size(144, 32);
            sensorTypeLabel.TabIndex = 2;
            sensorTypeLabel.Text = "Sensor Type";
            // 
            // sensorNameValue
            // 
            sensorNameValue.Location = new Point(12, 44);
            sensorNameValue.Name = "sensorNameValue";
            sensorNameValue.Size = new Size(391, 39);
            sensorNameValue.TabIndex = 3;
            // 
            // sensorTypeValue
            // 
            sensorTypeValue.Location = new Point(12, 134);
            sensorTypeValue.Name = "sensorTypeValue";
            sensorTypeValue.Size = new Size(391, 39);
            sensorTypeValue.TabIndex = 5;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sensorTypeValue);
            Controls.Add(sensorNameValue);
            Controls.Add(sensorTypeLabel);
            Controls.Add(sensorNameLabel);
            Controls.Add(saveButton);
            Name = "Form";
            Text = "System Sensor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Label sensorNameLabel;
        private Label sensorTypeLabel;
        private TextBox sensorNameValue;
        private TextBox sensorTypeValue;
    }
}
