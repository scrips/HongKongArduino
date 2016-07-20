using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHongKongArduino
{
    public partial class WinHongKongArduino : Form
    {
        private System.Resources.ResourceManager Rs;

        public WinHongKongArduino()
        {
            this.Rs = Properties.Resources.ResourceManager;
            InitializeComponent();
        }

        private void WinHongKongArduino_Load(object sender, EventArgs e)
        {
            
            string[] portNames = SerialPort.GetPortNames();

            foreach (string portName in portNames)
            {
                cmbCOMPort.Items.Add(portName);
            }

            cmbCOMPort.SelectedIndex = cmbCOMPort.Items.Count - 1;

            // マッピング
            cmbROMType.Items.Add(Rs.GetString("MAP_00"));
            cmbROMType.Items.Add(Rs.GetString("MAP_01"));
            cmbROMType.Items.Add(Rs.GetString("MAP_02"));
            cmbROMType.Items.Add(Rs.GetString("MAP_03"));
            cmbROMType.Items.Add(Rs.GetString("MAP_05"));
            cmbROMType.Items.Add(Rs.GetString("MAP_0A"));

            // ROM構成
            cmbROMCompo.Items.Add(Rs.GetString("CertType_00"));
            cmbROMCompo.Items.Add(Rs.GetString("CertType_01"));
            cmbROMCompo.Items.Add(Rs.GetString("CertType_02"));
            cmbROMCompo.Items.Add(Rs.GetString("CertType_03"));
            cmbROMCompo.Items.Add(Rs.GetString("CertType_04"));
            cmbROMCompo.Items.Add(Rs.GetString("CertType_05"));
            cmbROMCompo.Items.Add(Rs.GetString("CertType_06"));
            cmbROMCompo.Items.Add(Rs.GetString("CertType_09"));
            cmbROMCompo.Items.Add(Rs.GetString("CertType_0A"));

            // 拡張チップ
            cmbCoPro.Items.Add(Rs.GetString("CoPro_00"));
            cmbCoPro.Items.Add(Rs.GetString("CoPro_10"));
            cmbCoPro.Items.Add(Rs.GetString("CoPro_20"));
            cmbCoPro.Items.Add(Rs.GetString("CoPro_30"));
            cmbCoPro.Items.Add(Rs.GetString("CoPro_40"));
            cmbCoPro.Items.Add(Rs.GetString("CoPro_50"));

            // ROMサイズ
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_0D"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_0C"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_0B"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_0A"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_09"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_08"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_07"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_06"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_05"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_04"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_03"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_02"));
            cmbROMSize.Items.Add(Rs.GetString("ROMSize_01"));

            // RAMサイズ
            cmbRAMSize.Items.Add(Rs.GetString("RAMSize_00"));
            cmbRAMSize.Items.Add(Rs.GetString("RAMSize_01"));
            cmbRAMSize.Items.Add(Rs.GetString("RAMSize_02"));
            cmbRAMSize.Items.Add(Rs.GetString("RAMSize_03"));
            cmbRAMSize.Items.Add(Rs.GetString("RAMSize_04"));
            cmbRAMSize.Items.Add(Rs.GetString("RAMSize_05"));
            cmbRAMSize.Items.Add(Rs.GetString("RAMSize_06"));
            cmbRAMSize.Items.Add(Rs.GetString("RAMSize_07"));
        }

        // 吸い出し
        private void btnExtract_Click(object sender, EventArgs e)
        {
            // 入力チェック
            if (cmbROMType.SelectedItem == null)
            {
                MessageBox.Show("マッピングが選択されていません。");
                return;
            }
            if (cmbROMSize.SelectedItem == null)
            {
                MessageBox.Show("ROMサイズが選択されていません。");
                return;
            }

            // ファイルダイアログ
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SFC ROMファイル(*.sfc)|*.sfc|すべてのファイル(*.*)|*.*";
            sfd.FileName = txtTitle.Text.TrimEnd();
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // ROMサイズ取得
            int romsize = 0;
            String selectRomSize = cmbROMSize.SelectedItem.ToString();
            if (Rs.GetString("ROMSize_0D") == selectRomSize)
            {
                romsize = 0x800000;
            }
            else if (Rs.GetString("ROMSize_0C") == selectRomSize)
            {
                romsize = 0x400000;
            }
            else if (Rs.GetString("ROMSize_0B") == selectRomSize)
            {
                romsize = 0x200000;
            }
            else if (Rs.GetString("ROMSize_0A") == selectRomSize)
            {
                romsize = 0x100000;
            }
            else if (Rs.GetString("ROMSize_09") == selectRomSize)
            {
                romsize = 0x80000;
            }
            else if (Rs.GetString("ROMSize_08") == selectRomSize)
            {
                romsize = 0x40000;
            }
            else if (Rs.GetString("ROMSize_07") == selectRomSize)
            {
                romsize = 0x38000;
            }
            else if (Rs.GetString("ROMSize_06") == selectRomSize)
            {
                romsize = 0x30000;
            }
            else if (Rs.GetString("ROMSize_05") == selectRomSize)
            {
                romsize = 0x28000;
            }
            else if (Rs.GetString("ROMSize_04") == selectRomSize)
            {
                romsize = 0x20000;
            }
            else if (Rs.GetString("ROMSize_03") == selectRomSize)
            {
                romsize = 0x18000;
            }
            else if (Rs.GetString("ROMSize_02") == selectRomSize)
            {
                romsize = 0x10000;
            }
            else if (Rs.GetString("ROMSize_01") == selectRomSize)
            {
                romsize = 0x5000;
            }

            byte[] data = new byte[romsize];

            bool isLoROM = (cmbROMType.SelectedItem.ToString().Contains("LoROM"));

            // プログレスバー表示
            toolStripProgressBar.Visible = true;
            toolStripProgressBar.Maximum = romsize;

            // ステータス表示
            toolStripStatusLabel.Text = "吸い出し中...";

            // ボタン無効
            btnGetROMInfo.Enabled = false;
            btnExtract.Enabled = false;

            // 吸い出し
            sendControl(12); // OE + CS + !WE + !RST
            readROM(data, 0, 0, romsize, isLoROM);

            // ファイル書き込み
            File.WriteAllBytes(sfd.FileName, data);

            // ステータス表示
            toolStripStatusLabel.Text = "吸い出し完了";

            // ボタン有効
            btnGetROMInfo.Enabled = true;
            btnExtract.Enabled = true;
        }

        // ROM情報取得
        private void btnGetROMInfo_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[46];
            sendControl(12); // OE + CS + !WE + !RST
            readROM(data, 0, 0xFFB0, data.Length);


            // メーカーコード
            string makercode = "";
            for (int i = 0; i < 2; i++)
            {
                makercode += Convert.ToChar(data[i]);
            }
            txtMakerCode.Text = Rs.GetString("License_" + makercode);


            // ゲームコード
            string gamecode = "";
            for (int i = 2; i < 6; i++)
            {
                gamecode += Convert.ToChar(data[i]);
            }
            txtGameCode.Text = gamecode;

            // Fixed Value Check
            for (int i = 6; i < 14; i++)
            {
                if(data[i] != 0x00)
                {
                    MessageBox.Show("読み込まれたヘッダが正しくありません");
                    return;
                }
            }


            // 拡張RAMサイズ
            switch (data[14])
            {
                case 0x00:
                    txtExRAMSize.Text = Rs.GetString("ExRAMSize_00");
                    break;
                case 0x01:
                    txtExRAMSize.Text = Rs.GetString("ExRAMSize_01");
                    break;
                case 0x02:
                    txtExRAMSize.Text = Rs.GetString("ExRAMSize_02");
                    break;
                case 0x03:
                    txtExRAMSize.Text = Rs.GetString("ExRAMSize_03");
                    break;
                case 0x05:
                    txtExRAMSize.Text = Rs.GetString("ExRAMSize_05");
                    break;
                case 0x0A:
                    txtExRAMSize.Text = Rs.GetString("ExRAMSize_0A");
                    break;
                default:
                    // Undefined
                    txtExRAMSize.Text = "";
                    break;
            }


            // Special Version
            txtSpecialVer.Text = Convert.ToString(data[14]);


            // Sub Number
            txtSubNumber.Text = Convert.ToString(data[15]);


            // ROMタイトル
            string title = "";
            for (int i = 16; i < 37; i++)
            {
                title += Convert.ToChar(data[i]);
            }
            txtTitle.Text = title;


            // マッピング
            switch (data[37] & 0x0F)
            {
                case 0x00:
                    cmbROMType.SelectedItem = Rs.GetString("MAP_00");
                    break;
                case 0x01:
                    cmbROMType.SelectedItem = Rs.GetString("MAP_01");
                    break;
                case 0x02:
                    cmbROMType.SelectedItem = Rs.GetString("MAP_02");
                    break;
                case 0x03:
                    // 非対応：要Si5351A
                    cmbROMType.SelectedItem = Rs.GetString("MAP_03");
                    break;
                case 0x05:
                    cmbROMType.SelectedItem = Rs.GetString("MAP_05");
                    break;
                case 0x0A:
                    cmbROMType.SelectedItem = Rs.GetString("MAP_0A");
                    break;
                default:
                    // Undefined
                    cmbROMType.SelectedItem = "";
                    break;
            }


            // ROMスピード
            switch (data[37] & 0xF0)
            {
                case 0x20:
                    // Slow ROM
                    txtROMSpeed.Text = Rs.GetString("ROMSpeed_20");
                    break;
                case 0x30:
                    // Fast ROM
                    txtROMSpeed.Text = Rs.GetString("ROMSpeed_30");
                    break;
                default:
                    // Undefined
                    txtROMSpeed.Text = "";
                    break;
            }


            // ROM構成
            switch (data[38] & 0x0F)
            {
                case 0x00:
                    // DSPとの判別は後ほど行う
                    cmbROMCompo.SelectedItem = Rs.GetString("CertType_00");
                    break;
                case 0x01:
                    // DSPとの判別は後ほど行う
                    cmbROMCompo.SelectedItem = Rs.GetString("CertType_01");
                    break;
                case 0x02:
                    cmbROMCompo.SelectedItem = Rs.GetString("CertType_02");
                    break;
                case 0x03:
                    cmbROMCompo.SelectedItem = Rs.GetString("CertType_03");
                    break;
                case 0x04:
                    cmbROMCompo.SelectedItem = Rs.GetString("CertType_04");
                    break;
                case 0x05:
                    cmbROMCompo.SelectedItem = Rs.GetString("CertType_05");
                    break;
                case 0x06:
                    cmbROMCompo.SelectedItem = Rs.GetString("CertType_06");
                    break;
                case 0x09:
                    cmbROMCompo.SelectedItem = Rs.GetString("CertType_09");
                    break;
                case 0x0A:
                    cmbROMCompo.SelectedItem = Rs.GetString("CertType_0A");
                    break;
                default:
                    // Undefined
                    cmbROMCompo.SelectedItem = "";
                    break;
            }


            // 拡張チップ名
            switch (data[38] & 0xF0)
            {
                case 0x00:
                    // 存在しないはずだが仕様上こうなっているようなので
                    if ( (data[22] > 0x03))
                    {
                        cmbCoPro.SelectedItem = Rs.GetString("CoPro_00");
                    }
                    else
                    {
                        cmbCoPro.SelectedItem = "";
                    }
                    break;
                case 0x10:
                    // DSPとの判別は後ほど行う
                    cmbCoPro.SelectedItem = Rs.GetString("CoPro_10");
                    break;
                case 0x20:
                    cmbCoPro.SelectedItem = Rs.GetString("CoPro_20");
                    break;
                case 0x30:
                    cmbCoPro.SelectedItem = Rs.GetString("CoPro_30");
                    break;
                case 0x40:
                    cmbCoPro.SelectedItem = Rs.GetString("CoPro_40");
                    break;
                case 0x50:
                    cmbCoPro.SelectedItem = Rs.GetString("CoPro_50");
                    break;
                default:
                    // Undefined
                    cmbCoPro.SelectedItem = "";
                    break;
            }


            // ROMサイズ
            switch (data[39])
            {
                case 0x0D:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_0D");
                    break;
                case 0x0C:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_0C");
                    break;
                case 0x0B:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_0B");
                    break;
                case 0x0A:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_0A");
                    break;
                case 0x09:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_09");
                    break;
                case 0x08:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_08");
                    break;
                case 0x07:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_07");
                    break;
                case 0x06:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_06");
                    break;
                case 0x05:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_05");
                    break;
                case 0x04:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_04");
                    break;
                case 0x03:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_03");
                    break;
                case 0x02:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_02");
                    break;
                case 0x01:
                    cmbROMSize.SelectedItem = Rs.GetString("ROMSize_01");
                    break;
            }


            // RAMサイズ
            switch (data[40])
            {
                case 0x00:
                    cmbRAMSize.SelectedItem = Rs.GetString("RAMSize_00");
                    break;
                case 0x01:
                    cmbRAMSize.SelectedItem = Rs.GetString("RAMSize_01");
                    break;
                case 0x02:
                    cmbRAMSize.SelectedItem = Rs.GetString("RAMSize_02");
                    break;
                case 0x03:
                    cmbRAMSize.SelectedItem = Rs.GetString("RAMSize_03");
                    break;
                case 0x04:
                    cmbRAMSize.SelectedItem = Rs.GetString("RAMSize_04");
                    break;
                case 0x05:
                    cmbRAMSize.SelectedItem = Rs.GetString("RAMSize_05");
                    break;
                case 0x06:
                    cmbRAMSize.SelectedItem = Rs.GetString("RAMSize_06");
                    break;
                case 0x07:
                    cmbRAMSize.SelectedItem = Rs.GetString("RAMSize_07");
                    break;
            }


            // 発売国コード
            string countrycode = data[41].ToString("X2");
            txtCountry.Text = Rs.GetString("Country_" + countrycode);


            // Fixed value check
            if (data[42] != 0x33)
            {
                MessageBox.Show("読み込まれたヘッダが正しくありません");
                return;
            }

            // Version
            txtVersion.Text = "1." + Convert.ToString(data[43]);

            // Complement check
            txtComplementCheck.Text = Convert.ToString(data[44]);

            // Checksum
            txtCheckSum.Text = Convert.ToString(data[45]);

        }

        private void readROM(byte[] data, int offset, int address, int size, bool isLoROM = false)
        {
            string portName = cmbCOMPort.SelectedItem.ToString();
            SerialPort port = new SerialPort(portName, 115200);

            port.Open();

            byte[] cmd = new byte[7];
            if (isLoROM)
            {
                cmd[0] = (byte)'r'; // LoROM
            }
            else
            {
                cmd[0] = (byte)'R'; // HiROM
            }

            cmd[1] = (byte)(address >> (8 * 0));
            cmd[2] = (byte)(address >> (8 * 1));
            cmd[3] = (byte)(address >> (8 * 2));

            cmd[4] = (byte)(size >> (8 * 0));
            cmd[5] = (byte)(size >> (8 * 1));
            cmd[6] = (byte)(size >> (8 * 2));

            port.Write(cmd, 0, cmd.Length);

            int readbyte = 0;
            while (readbyte < size)
            {
                readbyte += port.Read(data, offset + readbyte, size - readbyte);

                // 進行状況表示
                toolStripProgressBar.Value = readbyte;
                Application.DoEvents();

                System.Threading.Thread.Sleep(1);
            }

            port.Close();
            port.Dispose();
        }

        private void readRAM(byte[] data, int offset, int address, int size, bool isLoROM = false)
        {
            string portName = cmbCOMPort.SelectedItem.ToString();
            SerialPort port = new SerialPort(portName, 115200);

            port.Open();

            byte[] cmd = new byte[7];
            if (isLoROM)
            {
                cmd[0] = (byte)'r'; // LoROM
            }
            else
            {
                cmd[0] = (byte)'R'; // HiROM
            }

            cmd[1] = (byte)(address >> (8 * 0));
            cmd[2] = (byte)(address >> (8 * 1));
            cmd[3] = (byte)(address >> (8 * 2));

            cmd[4] = (byte)(size >> (8 * 0));
            cmd[5] = (byte)(size >> (8 * 1));
            cmd[6] = (byte)(size >> (8 * 2));

            port.Write(cmd, 0, cmd.Length);

            int readbyte = 0;
            while (readbyte < size)
            {
                readbyte += port.Read(data, offset + readbyte, size - readbyte);

                // 進行状況表示
                toolStripProgressBar.Value = readbyte;
                Application.DoEvents();

                System.Threading.Thread.Sleep(1);
            }

            port.Close();
            port.Dispose();
        }

        private void sendControl(byte b)
        {
            string portName = cmbCOMPort.SelectedItem.ToString();
            SerialPort port = new SerialPort(portName, 115200);

            port.Open();

            byte[] cmd = new byte[2];
            cmd[0] = (byte)'c';
            cmd[1] = b;
            port.Write(cmd, 0, cmd.Length);

            port.Close();
            port.Dispose();
        }

    }
}
