using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class BHPL_comment : Form
    {
        BUS_BHPL_Comment bus_bhpl_comment = new BUS_BHPL_Comment();
        public BHPL_comment()
        {
            InitializeComponent();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void showAllComment()
        {
            DataTable dt = bus_bhpl_comment.BH_getComment();
            dataGridView1.DataSource = dt;
        }
        private void BHPL_comment_Load(object sender, EventArgs e)
        {
            showAllComment();
            DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
            dgvcCheckBox.HeaderText = "Tùy Chọn";
            dataGridView1.Columns.Add(dgvcCheckBox);

            DataGridViewTextBoxColumn dgvcId1 = new DataGridViewTextBoxColumn();
            dgvcId1.HeaderText = "MABL";
            DataGridViewTextBoxColumn dgvcId2 = new DataGridViewTextBoxColumn();
            dgvcId2.HeaderText = "HOTEN";
            DataGridViewTextBoxColumn dgvcId3 = new DataGridViewTextBoxColumn();
            dgvcId3.HeaderText = "EMAIL";
            DataGridViewTextBoxColumn dgvcId4 = new DataGridViewTextBoxColumn();
            dgvcId4.HeaderText = "DIACHI";
            DataGridViewTextBoxColumn dgvcId5 = new DataGridViewTextBoxColumn();
            dgvcId5.HeaderText = "NGAYBL";
            DataGridViewTextBoxColumn dgvcId6 = new DataGridViewTextBoxColumn();
            dgvcId6.HeaderText = "NOIDUNG";
            DataGridViewTextBoxColumn dgvcId7 = new DataGridViewTextBoxColumn();
            dgvcId7.HeaderText = "MASP";
            DataGridViewTextBoxColumn dgvcId8 = new DataGridViewTextBoxColumn();
            dgvcId8.HeaderText = "PHANLOAI";

            dataGridView2.Columns.Add(dgvcId1);
            dataGridView2.Columns.Add(dgvcId2);
            dataGridView2.Columns.Add(dgvcId3);
            dataGridView2.Columns.Add(dgvcId4);
            dataGridView2.Columns.Add(dgvcId5);
            dataGridView2.Columns.Add(dgvcId6);
            dataGridView2.Columns.Add(dgvcId7);
            dataGridView2.Columns.Add(dgvcId8);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                bool checkedCell;
                bool rowAlreadyExist = false;
                if (dataGridView1.Rows[i].Cells[8].Value == null)
                    checkedCell = false;
                else
                checkedCell = (bool)dataGridView1.Rows[i].Cells[8].Value;
                if (checkedCell == true)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];

                    if (dataGridView2.Rows.Count > 1)
                    {
                        for (int j = 0; j <= dataGridView2.Rows.Count - 2; j++)
                        {
                            if (row.Cells[0].Value.ToString() == dataGridView2.Rows[j].Cells[0].Value.ToString())
                            {
                                rowAlreadyExist = true;
                                break;
                            }
                        }


                        if (rowAlreadyExist == false)
                        {
                            if (checkedCell == true)
                            {
                                row.Cells[7].Value = 1;
                                dataGridView2.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[1].Value.ToString(),
                                                   row.Cells[2].Value.ToString(),
                                                   row.Cells[3].Value.ToString(),
                                                   row.Cells[4].Value.ToString(),
                                                   row.Cells[5].Value.ToString(),
                                                   row.Cells[6].Value.ToString(),
                                                   row.Cells[7].Value.ToString()
                                                   );
                            }
                            else
                            {
                                dataGridView2.Rows.Add(row.Cells[0].Value.ToString(),
                                                   row.Cells[1].Value.ToString(),
                                                   row.Cells[2].Value.ToString(),
                                                   row.Cells[3].Value.ToString(),
                                                   row.Cells[4].Value.ToString(),
                                                   row.Cells[5].Value.ToString(),
                                                   row.Cells[6].Value.ToString(),
                                                   row.Cells[7].Value.ToString()
                                                   );
                            }
                        }
                    }

                    else
                    {
                        if (checkedCell == true)
                        {
                            row.Cells[7].Value = 1;
                            dataGridView2.Rows.Add(row.Cells[0].Value.ToString(),
                                               row.Cells[1].Value.ToString(),
                                               row.Cells[2].Value.ToString(),
                                               row.Cells[3].Value.ToString(),
                                               row.Cells[4].Value.ToString(),
                                               row.Cells[5].Value.ToString(),
                                               row.Cells[6].Value.ToString(),
                                               row.Cells[7].Value.ToString()
                                               );
                        }
                        else
                        {
                            dataGridView2.Rows.Add(row.Cells[0].Value.ToString(),
                                               row.Cells[1].Value.ToString(),
                                               row.Cells[2].Value.ToString(),
                                               row.Cells[3].Value.ToString(),
                                               row.Cells[4].Value.ToString(),
                                               row.Cells[5].Value.ToString(),
                                               row.Cells[6].Value.ToString(),
                                               row.Cells[7].Value.ToString()
                                               );
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 0;
            for(int i=0;i<=dataGridView2.Rows.Count-2;i++)
            {
                Comment binhluan = new Comment(dataGridView2.Rows[i].Cells[1].Value.ToString(),
                    dataGridView2.Rows[i].Cells[2].Value.ToString(),
                    dataGridView2.Rows[i].Cells[3].Value.ToString(),
                    dataGridView2.Rows[i].Cells[5].Value.ToString(),
                    Convert.ToInt32(dataGridView2.Rows[i].Cells[6].Value.ToString()),
                    Convert.ToInt32(dataGridView2.Rows[i].Cells[7].Value.ToString()));

                if (bus_bhpl_comment.BH_updatecomment(binhluan, dataGridView2.Rows[i].Cells[0].Value.ToString()))
                {
                    k = 1;
                }
                else
                {
                    k = 0;
                }
            }
            if (k==1)
            {
                MessageBox.Show("Thêm comment xấu thành công!");
            }
            else
            {
                MessageBox.Show("Thêm comment xấu thất bại!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BHPL_comment_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Show();
        }
    }
}
