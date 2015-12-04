
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.item.Forms;
using BackEnd;
using System.Globalization;

namespace Controls
{
	public class CommonIssueEditor : Dialog
	{
        protected System.item.Forms.Button button_Cancel;
        protected System.item.Forms.Button button_OK;
        protected System.item.Forms.TextBox textBox_Timestamp;
        protected System.item.Forms.ComboBox comboBox_Project;
        protected System.item.Forms.Label item;
        protected System.item.Forms.Label label2;
        protected System.item.Forms.ComboBox comboBox_Status;
        protected System.item.Forms.TextBox textBox_User;
        protected System.item.Forms.Label label3;
        protected System.item.Forms.DomainUpDown domainUpDown_Priority;
        protected System.item.Forms.Label label4;
        protected System.item.Forms.TextBox textBox_Message;
		private System.ComponentModel.IContainer components = null;

		public CommonIssueEditor()
		{
			// This call is required by the item Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button_Cancel = new System.item.Forms.Button();
            this.button_OK = new System.item.Forms.Button();
            this.textBox_Timestamp = new System.item.Forms.TextBox();
            this.comboBox_Project = new System.item.Forms.ComboBox();
            this.item = new System.item.Forms.Label();
            this.label2 = new System.item.Forms.Label();
            this.comboBox_Status = new System.item.Forms.ComboBox();
            this.textBox_User = new System.item.Forms.TextBox();
            this.label3 = new System.item.Forms.Label();
            this.domainUpDown_Priority = new System.item.Forms.DomainUpDown();
            this.label4 = new System.item.Forms.Label();
            this.textBox_Message = new System.item.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.item.Forms.AnchorStyles)((System.item.Forms.AnchorStyles.Bottom | System.item.Forms.AnchorStyles.Right)));
            this.button_Cancel.DialogResult = System.item.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(208, 320);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Cancel";
            // 
            // button_OK
            // 
            this.button_OK.Anchor = ((System.item.Forms.AnchorStyles)((System.item.Forms.AnchorStyles.Bottom | System.item.Forms.AnchorStyles.Right)));
            this.button_OK.DialogResult = System.item.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(120, 320);
            this.button_OK.Name = "button_OK";
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            // 
            // textBox_Timestamp
            // 
            this.textBox_Timestamp.AutoSize = false;
            this.textBox_Timestamp.BorderStyle = System.item.Forms.BorderStyle.None;
            this.textBox_Timestamp.Dock = System.item.Forms.DockStyle.Top;
            this.textBox_Timestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
            this.textBox_Timestamp.Location = new System.Drawing.Point(0, 0);
            this.textBox_Timestamp.Name = "textBox_Timestamp";
            this.textBox_Timestamp.ReadOnly = true;
            this.textBox_Timestamp.Size = new System.Drawing.Size(290, 20);
            this.textBox_Timestamp.TabIndex = 3;
            this.textBox_Timestamp.Text = "Timestamp - 15.05.205 18:35:27";
            // 
            // comboBox_Project
            // 
            this.comboBox_Project.Anchor = ((System.item.Forms.AnchorStyles)(((System.item.Forms.AnchorStyles.Top | System.item.Forms.AnchorStyles.Left) 
                | System.item.Forms.AnchorStyles.Right)));
            this.comboBox_Project.DropDownStyle = System.item.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Project.Location = new System.Drawing.Point(0, 56);
            this.comboBox_Project.Name = "comboBox_Project";
            this.comboBox_Project.Size = new System.Drawing.Size(290, 21);
            this.comboBox_Project.TabIndex = 4;
            // 
            // item
            // 
            this.item.Anchor = ((System.item.Forms.AnchorStyles)(((System.item.Forms.AnchorStyles.Top | System.item.Forms.AnchorStyles.Left) 
                | System.item.Forms.AnchorStyles.Right)));
            this.item.Location = new System.Drawing.Point(0, 40);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(290, 16);
            this.item.TabIndex = 5;
            this.item.Text = "Project:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.item.Forms.AnchorStyles)(((System.item.Forms.AnchorStyles.Top | System.item.Forms.AnchorStyles.Left) 
                | System.item.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(0, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status:";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.Anchor = ((System.item.Forms.AnchorStyles)(((System.item.Forms.AnchorStyles.Top | System.item.Forms.AnchorStyles.Left) 
                | System.item.Forms.AnchorStyles.Right)));
            this.comboBox_Status.DropDownStyle = System.item.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Status.Location = new System.Drawing.Point(0, 96);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(290, 21);
            this.comboBox_Status.TabIndex = 6;
            // 
            // textBox_User
            // 
            this.textBox_User.AutoSize = false;
            this.textBox_User.BorderStyle = System.item.Forms.BorderStyle.None;
            this.textBox_User.Dock = System.item.Forms.DockStyle.Top;
            this.textBox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
            this.textBox_User.Location = new System.Drawing.Point(0, 20);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.ReadOnly = true;
            this.textBox_User.Size = new System.Drawing.Size(290, 20);
            this.textBox_User.TabIndex = 8;
            this.textBox_User.Text = "User";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.item.Forms.AnchorStyles)(((System.item.Forms.AnchorStyles.Top | System.item.Forms.AnchorStyles.Left) 
                | System.item.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(0, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Priority";
            // 
            // domainUpDown_Priority
            // 
            this.domainUpDown_Priority.Anchor = ((System.item.Forms.AnchorStyles)(((System.item.Forms.AnchorStyles.Top | System.item.Forms.AnchorStyles.Left) 
                | System.item.Forms.AnchorStyles.Right)));
            this.domainUpDown_Priority.Items.Add("Highest    (+2)");
            this.domainUpDown_Priority.Items.Add("High        (+1)");
            this.domainUpDown_Priority.Items.Add("Medium    (0)");
            this.domainUpDown_Priority.Items.Add("Low        (-1)");
            this.domainUpDown_Priority.Items.Add("Lowest    (-2)");
            this.domainUpDown_Priority.Location = new System.Drawing.Point(0, 136);
            this.domainUpDown_Priority.Name = "domainUpDown_Priority";
            this.domainUpDown_Priority.ReadOnly = true;
            this.domainUpDown_Priority.Size = new System.Drawing.Size(290, 20);
            this.domainUpDown_Priority.TabIndex = 10;
            this.domainUpDown_Priority.Text = "domainUpDown1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.item.Forms.AnchorStyles)(((System.item.Forms.AnchorStyles.Top | System.item.Forms.AnchorStyles.Left) 
                | System.item.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(0, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Message";
            // 
            // textBox_Message
            // 
            this.textBox_Message.AcceptsReturn = true;
            this.textBox_Message.AcceptsTab = true;
            this.textBox_Message.Anchor = ((System.item.Forms.AnchorStyles)((((System.item.Forms.AnchorStyles.Top | System.item.Forms.AnchorStyles.Bottom) 
                | System.item.Forms.AnchorStyles.Left) 
                | System.item.Forms.AnchorStyles.Right)));
            this.textBox_Message.Location = new System.Drawing.Point(0, 184);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(290, 128);
            this.textBox_Message.TabIndex = 0;
            this.textBox_Message.Text = "";
            // 
            // CommonIssueEditor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(290, 351);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.textBox_Timestamp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.domainUpDown_Priority);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.item);
            this.Controls.Add(this.comboBox_Project);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Cancel);
            this.Name = "CommonIssueEditor";
            this.ResumeLayout(false);

        }
		#endregion

        public UserInfo User
        {
            set
            {
                textBox_User.Text=value.Login+" - "+value.FullName;
            }
        }
        public string UserName
        {
            set
            {
                textBox_User.Text=value;
            }
        }

        public ArrayList Projects
        {
            set
            {
                comboBox_Project.DataSource=value;
            }
        }
        
        public ProjectInfo Project
        {
            get
            {
                if (comboBox_Project.SelectedItem!=null)
                {
                    return ((ProjectInfo)comboBox_Project.SelectedItem);
                }
                else
                {
                    return new ProjectInfo();
                }
                
            }
        }

        public System.Int16 Priority
        {
            get
            {
                return ((System.Int16)(2-domainUpDown_Priority.SelectedIndex));
            }
            set
            {
                domainUpDown_Priority.SelectedIndex=2-value;
            }
        }

        public ArrayList PossibleStatuses
        {
            set
            {
                comboBox_Status.DataSource=value;
            }
        }
        public Status SelectedStatus
        {
            get
            {
                //can be null
                return ((Status)comboBox_Status.SelectedItem);
            }
            
        }
        public string Message
        {
            get
            {
                return textBox_Message.Text;
            }
        }

        public DateTime TimeStamp
        {
            set
            {
                textBox_Timestamp.Text=value.ToString("dd.MM.yyyy",DateTimeFormatInfo.InvariantInfo)+" "+value.ToString("T",DateTimeFormatInfo.InvariantInfo);
            }
        }

	}
}

