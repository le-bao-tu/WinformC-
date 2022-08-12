using BTL_QLSV_WINFORM.DataAccessConnect;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;
namespace BTL_QLSV_WINFORM
{
    public partial class FrmDSSV : Form
    {
        public FrmDSSV()
        {
            InitializeComponent();
        }

        private void FrmDSSV_Load(object sender, EventArgs e)
        {
            showAllStudent();
        }

        // duyệt tất cả danh sách sinh viên
        private void showAllStudent()
        {
            dataGridViewStudent.DataSource = null; // reset lại cơ sở dữ liệu
            // gọi thủ tục
            SqlDataAdapter da = new SqlDataAdapter("spu_GetAllStudents", SQLServerConnection.StringConnection);
            // khi gọi bằng thủ tục phải thêm dòng này
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            // tạo DataSet để chức dữ liệu
            DataSet ds = new DataSet();
            da.Fill(ds, "Student");
            //Hiển thị dữ liệu lên Grid view
            dataGridViewStudent.DataSource = ds.Tables["Student"];
        }

        // tạo sự kiện để gọi sang form FrmStudent
        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStudent.CurrentRow != null)
            {
                var msv = dataGridViewStudent.CurrentRow.Cells[0].Value.ToString();
                //truyền mã sinh viên này sang form sinh viên (FrmStudent)
           
                new FrmStudent(msv).ShowDialog();
                // sau khi nó ấn cập nhật xong nó gọi lại hàm bên dưới để load lại dữ liệu
                showAllStudent();

            }
        }

        // Thêm mới sinh viên
        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            new FrmStudent(null).ShowDialog();

            // sau khi nó ấn cập nhật xong nó gọi lại hàm bên dưới để load lại dữ liệu
            showAllStudent();
        }

        // Xóa sinh Viên
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_DeleteStudent";
                cmd.CommandType = CommandType.StoredProcedure;
                var msv = dataGridViewStudent.CurrentRow.Cells[0].Value.ToString();
                cmd.Parameters.AddWithValue("studentId", msv);
                int row = cmd.ExecuteNonQuery();
                if (row == 1)
                {
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showAllStudent();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // khi người dùng ấn nút tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
            cmd.CommandText = "spu_SearchStudent";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", txtSearch.Text.Trim());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewStudent.DataSource = dt;
        }

        // bắt gọi sự kiện text Change
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
            cmd.CommandText = "spu_SearchStudent";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", txtSearch.Text.Trim());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewStudent.DataSource = dt;

        }
       
        private void Excel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("studentId");
            DataColumn col2 = new DataColumn("createdDate");
            DataColumn col3 = new DataColumn("creator");
            DataColumn col4 = new DataColumn("updateDay");
            DataColumn col5 = new DataColumn("updater");
            DataColumn col6 = new DataColumn("fullName");
            DataColumn col7 = new DataColumn("middleName");
            DataColumn col8 = new DataColumn("birthday");
            DataColumn col9 = new DataColumn("sex");
            DataColumn col10 = new DataColumn("homeTown");
            DataColumn col11 = new DataColumn("address");
            DataColumn col12 = new DataColumn("phone");
            DataColumn col13 = new DataColumn("email");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);
            dataTable.Columns.Add(col10);
            dataTable.Columns.Add(col11);
            dataTable.Columns.Add(col12);
            dataTable.Columns.Add(col13);


            foreach (DataGridViewRow dtgvRow in dataGridViewStudent.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;
                dtrow[6] = dtgvRow.Cells[6].Value;
                dtrow[7] = dtgvRow.Cells[7].Value;
                dtrow[8] = dtgvRow.Cells[8].Value;
                dtrow[9] = dtgvRow.Cells[9].Value;
                dtrow[10] = dtgvRow.Cells[10].Value;
                dtrow[11] = dtgvRow.Cells[11].Value;
                dtrow[12] = dtgvRow.Cells[12].Value;

                dataTable.Rows.Add(dtrow);
            }

            ExportFile(dataTable, "Danh sách", "DANH SÁCH SINH VIÊN");
        }

        // hàm xuất excel 
        public void ExportFile(DataTable dataTable, string sheetName , string title)
        {
            // tạo các đối tượng Excel 
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // tạo phần tiêu đề 

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "I1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã sinh viên";
            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Ngày tạo ";
            cl2.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Người tạo ";
            cl3.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày cập nhật ";
            cl4.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Người cập nhật  ";
            cl5.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Họ và Tên ";
            cl6.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Tên đệm ";
            cl7.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Ngày sinh  ";
            cl8.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Giới tính ";
            cl9.ColumnWidth = 10.0;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Quê quán ";
            cl10.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");
            cl11.Value2 = "Địa chỉ ";
            cl11.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");
            cl12.Value2 = "Phone ";
            cl12.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl13 = oSheet.get_Range("M3", "M3");
            cl13.Value2 = "Email ";
            cl13.ColumnWidth = 25.0;

            // thiết lập đọ dài của màu nền 
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "M3");
            rowHead.Font.Bold = true;
            // kẻ viền 
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // thiết lập màu nền 

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // tạo mảng theo database 

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            // chuyển dữ liệu từ dataTabe vào mảng đói tượng 

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            // thiết lập vùng điên dữ liệu 
            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // ô bắt đầu điền dữ liệu 
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // ô kết thức dữ liệu 
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // lấy về vùng điền dữ liệu 
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            // điền dữ liệu vào vùng đã thiết lập 
            range.Value2 = arr;

            // KẺ VIỀN 
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;


            // căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }


    }
}
