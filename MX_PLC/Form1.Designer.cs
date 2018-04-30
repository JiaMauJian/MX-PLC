namespace MX_PLC
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grp_Output = new System.Windows.Forms.GroupBox();
            this.txtReturnCode = new System.Windows.Forms.TextBox();
            this.lbl_RetrunCode = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtDeviceDataBlock = new System.Windows.Forms.TextBox();
            this.lbl_DeviceDataBlock = new System.Windows.Forms.Label();
            this.txtDeviceSizeBlock = new System.Windows.Forms.TextBox();
            this.lbl_DeviceSizeBlock = new System.Windows.Forms.Label();
            this.txtDeviceNameBlock = new System.Windows.Forms.TextBox();
            this.lbl_DeviceNameBlock = new System.Windows.Forms.Label();
            this.btnReadDeviceBlock = new System.Windows.Forms.Button();
            this.btnConn = new System.Windows.Forms.Button();
            this.txtLogicalStationNumber = new System.Windows.Forms.TextBox();
            this.lbl_LogicalStationNumber = new System.Windows.Forms.Label();
            this.btnWriteDeviceBlock = new System.Windows.Forms.Button();
            this.axActUtlType1 = new AxActUtlTypeLib.AxActUtlType();
            this.grp_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axActUtlType1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Output
            // 
            this.grp_Output.Controls.Add(this.txtReturnCode);
            this.grp_Output.Controls.Add(this.lbl_RetrunCode);
            this.grp_Output.Controls.Add(this.lbl_Data);
            this.grp_Output.Controls.Add(this.txtData);
            this.grp_Output.Location = new System.Drawing.Point(22, 245);
            this.grp_Output.Name = "grp_Output";
            this.grp_Output.Size = new System.Drawing.Size(496, 152);
            this.grp_Output.TabIndex = 91;
            this.grp_Output.TabStop = false;
            this.grp_Output.Text = "Output";
            // 
            // txtReturnCode
            // 
            this.txtReturnCode.Location = new System.Drawing.Point(104, 16);
            this.txtReturnCode.Name = "txtReturnCode";
            this.txtReturnCode.ReadOnly = true;
            this.txtReturnCode.Size = new System.Drawing.Size(128, 22);
            this.txtReturnCode.TabIndex = 50;
            this.txtReturnCode.TabStop = false;
            // 
            // lbl_RetrunCode
            // 
            this.lbl_RetrunCode.Location = new System.Drawing.Point(24, 16);
            this.lbl_RetrunCode.Name = "lbl_RetrunCode";
            this.lbl_RetrunCode.Size = new System.Drawing.Size(72, 16);
            this.lbl_RetrunCode.TabIndex = 50;
            this.lbl_RetrunCode.Text = "Return Code:";
            // 
            // lbl_Data
            // 
            this.lbl_Data.Location = new System.Drawing.Point(24, 40);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(72, 16);
            this.lbl_Data.TabIndex = 50;
            this.lbl_Data.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.AcceptsReturn = true;
            this.txtData.Location = new System.Drawing.Point(24, 56);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(456, 80);
            this.txtData.TabIndex = 50;
            this.txtData.TabStop = false;
            // 
            // txtDeviceDataBlock
            // 
            this.txtDeviceDataBlock.AcceptsReturn = true;
            this.txtDeviceDataBlock.Location = new System.Drawing.Point(238, 115);
            this.txtDeviceDataBlock.Multiline = true;
            this.txtDeviceDataBlock.Name = "txtDeviceDataBlock";
            this.txtDeviceDataBlock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeviceDataBlock.Size = new System.Drawing.Size(96, 72);
            this.txtDeviceDataBlock.TabIndex = 90;
            // 
            // lbl_DeviceDataBlock
            // 
            this.lbl_DeviceDataBlock.Location = new System.Drawing.Point(238, 99);
            this.lbl_DeviceDataBlock.Name = "lbl_DeviceDataBlock";
            this.lbl_DeviceDataBlock.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceDataBlock.TabIndex = 89;
            this.lbl_DeviceDataBlock.Text = "DeviceData:";
            // 
            // txtDeviceSizeBlock
            // 
            this.txtDeviceSizeBlock.Location = new System.Drawing.Point(144, 115);
            this.txtDeviceSizeBlock.Name = "txtDeviceSizeBlock";
            this.txtDeviceSizeBlock.Size = new System.Drawing.Size(72, 22);
            this.txtDeviceSizeBlock.TabIndex = 88;
            // 
            // lbl_DeviceSizeBlock
            // 
            this.lbl_DeviceSizeBlock.Location = new System.Drawing.Point(144, 99);
            this.lbl_DeviceSizeBlock.Name = "lbl_DeviceSizeBlock";
            this.lbl_DeviceSizeBlock.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceSizeBlock.TabIndex = 87;
            this.lbl_DeviceSizeBlock.Text = "DataSize:";
            // 
            // txtDeviceNameBlock
            // 
            this.txtDeviceNameBlock.AcceptsReturn = true;
            this.txtDeviceNameBlock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeviceNameBlock.Location = new System.Drawing.Point(20, 115);
            this.txtDeviceNameBlock.Name = "txtDeviceNameBlock";
            this.txtDeviceNameBlock.Size = new System.Drawing.Size(96, 22);
            this.txtDeviceNameBlock.TabIndex = 86;
            // 
            // lbl_DeviceNameBlock
            // 
            this.lbl_DeviceNameBlock.Location = new System.Drawing.Point(20, 99);
            this.lbl_DeviceNameBlock.Name = "lbl_DeviceNameBlock";
            this.lbl_DeviceNameBlock.Size = new System.Drawing.Size(88, 16);
            this.lbl_DeviceNameBlock.TabIndex = 85;
            this.lbl_DeviceNameBlock.Text = "DevicelName:";
            // 
            // btnReadDeviceBlock
            // 
            this.btnReadDeviceBlock.Location = new System.Drawing.Point(20, 194);
            this.btnReadDeviceBlock.Name = "btnReadDeviceBlock";
            this.btnReadDeviceBlock.Size = new System.Drawing.Size(75, 23);
            this.btnReadDeviceBlock.TabIndex = 84;
            this.btnReadDeviceBlock.Text = "ReadDeviceBlock";
            this.btnReadDeviceBlock.UseVisualStyleBackColor = true;
            this.btnReadDeviceBlock.Click += new System.EventHandler(this.btnReadDeviceBlock_Click);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(20, 52);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 23);
            this.btnConn.TabIndex = 83;
            this.btnConn.Text = "Conn";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // txtLogicalStationNumber
            // 
            this.txtLogicalStationNumber.Location = new System.Drawing.Point(146, 18);
            this.txtLogicalStationNumber.Name = "txtLogicalStationNumber";
            this.txtLogicalStationNumber.Size = new System.Drawing.Size(40, 22);
            this.txtLogicalStationNumber.TabIndex = 82;
            this.txtLogicalStationNumber.Text = "0";
            // 
            // lbl_LogicalStationNumber
            // 
            this.lbl_LogicalStationNumber.Location = new System.Drawing.Point(20, 24);
            this.lbl_LogicalStationNumber.Name = "lbl_LogicalStationNumber";
            this.lbl_LogicalStationNumber.Size = new System.Drawing.Size(120, 16);
            this.lbl_LogicalStationNumber.TabIndex = 81;
            this.lbl_LogicalStationNumber.Text = "LogicalStationNumber:";
            // 
            // btnWriteDeviceBlock
            // 
            this.btnWriteDeviceBlock.Location = new System.Drawing.Point(126, 194);
            this.btnWriteDeviceBlock.Name = "btnWriteDeviceBlock";
            this.btnWriteDeviceBlock.Size = new System.Drawing.Size(75, 23);
            this.btnWriteDeviceBlock.TabIndex = 92;
            this.btnWriteDeviceBlock.Text = "WriteDeviceBlock";
            this.btnWriteDeviceBlock.UseVisualStyleBackColor = true;
            this.btnWriteDeviceBlock.Click += new System.EventHandler(this.btnWriteDeviceBlock_Click);
            // 
            // axActUtlType1
            // 
            this.axActUtlType1.Enabled = true;
            this.axActUtlType1.Location = new System.Drawing.Point(426, 138);
            this.axActUtlType1.Name = "axActUtlType1";
            this.axActUtlType1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axActUtlType1.OcxState")));
            this.axActUtlType1.Size = new System.Drawing.Size(32, 32);
            this.axActUtlType1.TabIndex = 93;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 471);
            this.Controls.Add(this.axActUtlType1);
            this.Controls.Add(this.grp_Output);
            this.Controls.Add(this.txtDeviceDataBlock);
            this.Controls.Add(this.lbl_DeviceDataBlock);
            this.Controls.Add(this.txtDeviceSizeBlock);
            this.Controls.Add(this.lbl_DeviceSizeBlock);
            this.Controls.Add(this.txtDeviceNameBlock);
            this.Controls.Add(this.lbl_DeviceNameBlock);
            this.Controls.Add(this.btnReadDeviceBlock);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.txtLogicalStationNumber);
            this.Controls.Add(this.lbl_LogicalStationNumber);
            this.Controls.Add(this.btnWriteDeviceBlock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_Output.ResumeLayout(false);
            this.grp_Output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axActUtlType1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox grp_Output;
        internal System.Windows.Forms.TextBox txtReturnCode;
        internal System.Windows.Forms.Label lbl_RetrunCode;
        internal System.Windows.Forms.Label lbl_Data;
        internal System.Windows.Forms.TextBox txtData;
        internal System.Windows.Forms.TextBox txtDeviceDataBlock;
        internal System.Windows.Forms.Label lbl_DeviceDataBlock;
        internal System.Windows.Forms.TextBox txtDeviceSizeBlock;
        internal System.Windows.Forms.Label lbl_DeviceSizeBlock;
        internal System.Windows.Forms.TextBox txtDeviceNameBlock;
        internal System.Windows.Forms.Label lbl_DeviceNameBlock;
        private System.Windows.Forms.Button btnReadDeviceBlock;
        private System.Windows.Forms.Button btnConn;
        internal System.Windows.Forms.TextBox txtLogicalStationNumber;
        internal System.Windows.Forms.Label lbl_LogicalStationNumber;
        private System.Windows.Forms.Button btnWriteDeviceBlock;
        private AxActUtlTypeLib.AxActUtlType axActUtlType1;
    }
}

