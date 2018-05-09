using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MX_PLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool GetIntValue(TextBox lptxt_SourceOfIntValue, out int iGottenIntValue)
        {
            iGottenIntValue = 0;
            //Get the value as 32bit integer from a TextBox
            try
            {
                iGottenIntValue = Convert.ToInt32(lptxt_SourceOfIntValue.Text);
            }

            //When the value is nothing or out of the range, the exception is processed.
            catch (Exception exExcepion)
            {
                MessageBox.Show(exExcepion.Message,
                                  Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Normal End
            return true;
        }

        private void ClearDisplay()
        {
            //Clear TextBox of 'ReturnCode','Data'
            txtReturnCode.Text = "";
            txtData.Text = "";
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            int iReturnCode = 0;                //Return code
            int iLogicalStationNumber;      //LogicalStationNumber for ActUtlType

            try
            {
                if (GetIntValue(txtLogicalStationNumber, out iLogicalStationNumber) != true)
                {
                    //If failed, this process is end.			
                    return;
                }

                axActUtlType1.ActLogicalStationNumber = iLogicalStationNumber;
                iReturnCode = axActUtlType1.Open();

                //if (iReturnCode == 0)
                //{
                //    txtLogicalStationNumber.Enabled = false;
                //}
                txtReturnCode.Text = String.Format("0x{0:x8}", iReturnCode);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iReturnCode = 0;                //Return code
            int iLogicalStationNumber;      //LogicalStationNumber for ActUtlType

            try
            {
                axActUtlType1.Close();

                if (GetIntValue(txtLogicalStationNumber, out iLogicalStationNumber) != true)
                {
                    //If failed, this process is end.			
                    return;
                }

                axActUtlType1.ActLogicalStationNumber = iLogicalStationNumber;
                iReturnCode = axActUtlType1.Open();

                //if (iReturnCode == 0)
                //{
                //    txtLogicalStationNumber.Enabled = false;
                //}
                txtReturnCode.Text = String.Format("0x{0:x8}", iReturnCode);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void btnReadDeviceBlock2_Click(object sender, EventArgs e)
        {
            int iReturnCode;				//Return code
            String szDeviceName = "";		//List data for 'DeviceName'
            int iNumberOfData = 0;			//Data for 'iNumberOfData'
            short[] arrDeviceValue;		    //Data for 'DeviceValue'
            int iNumber;					//Loop counter
            System.String[] arrData;	    //Array for 'Data'


            //Displayed output data is cleared.
            txtMes.Text = "";

            //Get the list of 'DeviceName'.
            //  Join each line(StringType array) of 'DeviceName' by the separator '\n',
            //  and create a joined string data.
            szDeviceName = String.Join("\n", txtDeviceNameBlock2.Lines);

            //Check the 'DeviceSize'.(If succeeded, the value is gotten.)
            if (!GetIntValue(txtDeviceSizeBlock2, out iNumberOfData))
            {
                //If failed, this process is end.
                return;
            }

            //Assign the array for 'DeviceValue'.
            arrDeviceValue = new short[iNumberOfData];

            //
            //Processing of ReadDeviceBlock2 method
            //
            try
            {
                int data;
                //The ReadDeviceBlock2 method is executed.
                iReturnCode = axActUtlType1.ReadDeviceBlock2(szDeviceName,
                                                             iNumberOfData,
                                                             out arrDeviceValue[0]);
            }

            //Exception processing			
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Name,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            //txtReturnCode.Text = String.Format("0x{0:x8}", iReturnCode);

            //
            //Display the read data
            //
            //When the ReadDeviceBlock2 method is succeeded, display the read data.
            if (iReturnCode == 0)
            {
                //Assign array for the read data.
                arrData = new System.String[iNumberOfData];

                //Copy the read data to the 'arrData'.
                for (iNumber = 0; iNumber < iNumberOfData; iNumber++)
                {
                    arrData[iNumber] = arrDeviceValue[iNumber].ToString();
                }

                //Set the read data to the 'Data', and display it.
                txtMes.Lines = arrData;
            }
        }

        private void btnReadDeviceBlock_Click(object sender, EventArgs e)
        {
            int iReturnCode;				//Return code
            String szDeviceName = "";		//List data for 'DeviceName'
            int iNumberOfData = 0;			//Data for 'iNumberOfData'
            short[] arrDeviceValue;		    //Data for 'DeviceValue'
            int iNumber;					//Loop counter
            System.String[] arrData;	    //Array for 'Data'


            //Displayed output data is cleared.
            ClearDisplay();

            //Get the list of 'DeviceName'.
            //  Join each line(StringType array) of 'DeviceName' by the separator '\n',
            //  and create a joined string data.
            szDeviceName = String.Join("\n", txtDeviceNameBlock.Lines);

            //Check the 'DeviceSize'.(If succeeded, the value is gotten.)
            if (!GetIntValue(txtDeviceSizeBlock, out iNumberOfData))
            {
                //If failed, this process is end.
                return;
            }

            //Assign the array for 'DeviceValue'.
            arrDeviceValue = new short[iNumberOfData];

            //
            //Processing of ReadDeviceBlock2 method
            //
            try
            {
                int data;
                //The ReadDeviceBlock2 method is executed.
                iReturnCode = axActUtlType1.ReadDeviceBlock2(szDeviceName,
                                                             iNumberOfData,
                                                             out arrDeviceValue[0]);
            }

            //Exception processing			
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Name,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            txtReturnCode.Text = String.Format("0x{0:x8}", iReturnCode);

            //
            //Display the read data
            //
            //When the ReadDeviceBlock2 method is succeeded, display the read data.
            if (iReturnCode == 0)
            {
                //Assign array for the read data.
                arrData = new System.String[iNumberOfData];

                //Copy the read data to the 'arrData'.
                for (iNumber = 0; iNumber < iNumberOfData; iNumber++)
                {
                    arrData[iNumber] = arrDeviceValue[iNumber].ToString();
                }

                //Set the read data to the 'Data', and display it.
                txtData.Lines = arrData;
            }
        }

        private void btnWriteDeviceBlock_Click(object sender, EventArgs e)
        {
            int iReturnCode;				//Return code
            String szDeviceName = "";		//List data for 'DeviceName'
            int iNumberOfData = 0;			//Data for 'DeviceSize'
            short[] arrDeviceValue;		    //Data for 'DeviceValue'
            int iNumber;					//Loop counter
            int iSizeOfIntArray;		    //

            //Displayed output data is cleared.
            ClearDisplay();

            //Get the list of 'DeviceName'.
            //  Join each line(StringType array) of 'DeviceName' by the separator '\n',
            //  and create a joined string data.
            szDeviceName = String.Join("\n", txtDeviceNameBlock3.Lines);

            //Check the 'DeviceSize'.(If succeeded, the value is gotten.)
            if (!GetIntValue(txtDeviceSizeBlock3, out iNumberOfData))
            {
                //If failed, this process is end.
                return;
            }

            //Get size for 'DeviceValue'
            iSizeOfIntArray = txtDeviceDataBlock3.Lines.Length;
            //Assign the array for 'DeviceValue'.
            arrDeviceValue = new short[iNumberOfData];

            //Convert the 'DeviceValue'.
            for (iNumber = 0; iNumber < iSizeOfIntArray; iNumber++)
            {
                try
                {
                    arrDeviceValue[iNumber]
                        = Convert.ToInt16(txtDeviceDataBlock3.Lines[iNumber]);
                }

                //Exception processing
                catch (Exception exExcepion)
                {
                    MessageBox.Show(exExcepion.Message,
                                      Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //
            //Processing of WriteDeviceBlock2 method
            //
            try
            {
                //The WriteDeviceRandom2 method is executed.
                iReturnCode = axActUtlType1.WriteDeviceBlock2(szDeviceName,
                                                                iNumberOfData,
                                                                ref arrDeviceValue[0]);
            }

            //Exception processing			
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Name,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            //txtReturnCode.Text = String.Format("0x{0:x8} [HEX]", iReturnCode);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtReturnCode.Text == "0x00000000")
            {
                txtDeviceNameBlock2.Text = "M688";
                txtDeviceSizeBlock2.Text = "1";
                btnReadDeviceBlock2_Click(null, null);
            }
        }
    }
}
