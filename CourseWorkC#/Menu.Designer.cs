namespace CourseWorkC_
{
    partial class Menu
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
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Minutes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.TextBox();
            this.buttonAddTrain = new System.Windows.Forms.Button();
            this.buttonTimeInfo = new System.Windows.Forms.Button();
            this.buttonDepartureTime = new System.Windows.Forms.Button();
            this.buttonNearestTrain = new System.Windows.Forms.Button();
            this.buttonListClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Platform = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView1.AllowColumnReorder = true;
            this.ListView1.AllowDrop = true;
            this.ListView1.BackgroundImageTiled = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "listViewGroup1";
            listViewGroup7.Header = "ListViewGroup";
            listViewGroup7.Name = "listViewGroup2";
            listViewGroup8.Header = "ListViewGroup";
            listViewGroup8.Name = "listViewGroup3";
            listViewGroup9.Header = "ListViewGroup";
            listViewGroup9.Name = "listViewGroup4";
            listViewGroup10.Header = "ListViewGroup";
            listViewGroup10.Name = "listViewGroup5";
            this.ListView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10});
            this.ListView1.HideSelection = false;
            this.ListView1.HotTracking = true;
            this.ListView1.HoverSelection = true;
            this.ListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ListView1.LabelEdit = true;
            this.ListView1.Location = new System.Drawing.Point(293, 41);
            this.ListView1.Name = "ListView1";
            this.ListView1.RightToLeftLayout = true;
            this.ListView1.ShowGroups = false;
            this.ListView1.Size = new System.Drawing.Size(406, 313);
            this.ListView1.TabIndex = 6;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Destination";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time of departure";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Platform";
            this.columnHeader4.Width = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Schedule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Information about train";
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(99, 64);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(100, 22);
            this.Destination.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Destination";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Time of departure of the train";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hours";
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(99, 160);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(100, 22);
            this.Hours.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Minutes";
            // 
            // Minutes
            // 
            this.Minutes.Location = new System.Drawing.Point(99, 209);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(100, 22);
            this.Minutes.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Seconds";
            // 
            // Seconds
            // 
            this.Seconds.Location = new System.Drawing.Point(99, 256);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(100, 22);
            this.Seconds.TabIndex = 25;
            // 
            // buttonAddTrain
            // 
            this.buttonAddTrain.Location = new System.Drawing.Point(25, 402);
            this.buttonAddTrain.Name = "buttonAddTrain";
            this.buttonAddTrain.Size = new System.Drawing.Size(200, 36);
            this.buttonAddTrain.TabIndex = 26;
            this.buttonAddTrain.Text = "Add a train to the schedule";
            this.buttonAddTrain.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAddTrain.UseVisualStyleBackColor = true;
            this.buttonAddTrain.Click += new System.EventHandler(this.ButtonAddTrain_Click);
            // 
            // buttonTimeInfo
            // 
            this.buttonTimeInfo.Location = new System.Drawing.Point(271, 405);
            this.buttonTimeInfo.Name = "buttonTimeInfo";
            this.buttonTimeInfo.Size = new System.Drawing.Size(101, 23);
            this.buttonTimeInfo.TabIndex = 27;
            this.buttonTimeInfo.Text = "Get the Time";
            this.buttonTimeInfo.UseVisualStyleBackColor = true;
            this.buttonTimeInfo.Click += new System.EventHandler(this.ButtonTimeInfo_Click);
            // 
            // buttonDepartureTime
            // 
            this.buttonDepartureTime.Location = new System.Drawing.Point(406, 392);
            this.buttonDepartureTime.Name = "buttonDepartureTime";
            this.buttonDepartureTime.Size = new System.Drawing.Size(107, 44);
            this.buttonDepartureTime.TabIndex = 28;
            this.buttonDepartureTime.Text = "Get the train departure Time";
            this.buttonDepartureTime.UseVisualStyleBackColor = true;
            this.buttonDepartureTime.Click += new System.EventHandler(this.ButtonDepartureTime_Click);
            // 
            // buttonNearestTrain
            // 
            this.buttonNearestTrain.Location = new System.Drawing.Point(547, 392);
            this.buttonNearestTrain.Name = "buttonNearestTrain";
            this.buttonNearestTrain.Size = new System.Drawing.Size(115, 44);
            this.buttonNearestTrain.TabIndex = 29;
            this.buttonNearestTrain.Text = "The nearest train departure Time";
            this.buttonNearestTrain.UseVisualStyleBackColor = true;
            this.buttonNearestTrain.Click += new System.EventHandler(this.ButtonNearestTrain_Click);
            // 
            // buttonListClear
            // 
            this.buttonListClear.Location = new System.Drawing.Point(693, 405);
            this.buttonListClear.Name = "buttonListClear";
            this.buttonListClear.Size = new System.Drawing.Size(95, 23);
            this.buttonListClear.TabIndex = 30;
            this.buttonListClear.Text = "Clear the list";
            this.buttonListClear.UseVisualStyleBackColor = true;
            this.buttonListClear.Click += new System.EventHandler(this.ButtonListClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Platform";
            // 
            // Platform
            // 
            this.Platform.Location = new System.Drawing.Point(99, 308);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(100, 22);
            this.Platform.TabIndex = 32;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonListClear);
            this.Controls.Add(this.buttonNearestTrain);
            this.Controls.Add(this.buttonDepartureTime);
            this.Controls.Add(this.buttonTimeInfo);
            this.Controls.Add(this.buttonAddTrain);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListView1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Hours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Minutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Seconds;
        private System.Windows.Forms.Button buttonAddTrain;
        private System.Windows.Forms.Button buttonTimeInfo;
        private System.Windows.Forms.Button buttonDepartureTime;
        private System.Windows.Forms.Button buttonNearestTrain;
        private System.Windows.Forms.Button buttonListClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Platform;
    }
}

