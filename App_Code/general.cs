                                                              using System;
using System.Net;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Drawing.Drawing2D;

/// <summary>
/// Summary description for general
/// </summary>
public class general
{
    public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
    //public SqlCommand command = new SqlCommand();
    public general()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void connect()
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        catch
        {
        }
    }
    public void closeconnect()
    {
        try
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        catch
        {
        }
    }
    public DataTable GetDataTable(string str)
    {
        connect();
        SqlCommand command = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = System.Data.CommandType.Text;
        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];
    }
    public DataTable GetDataTableSP(string str, string FieldName, int Id)
    {
        connect();
        SqlCommand command = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, Id);


        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];

    }
    public DataTable GetDataTableSPWithField(string strSPName, string FieldName, string FieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];

    }
    public DataTable GetDataTableSPWithTwoField(string strSPName, string FieldName, int FieldValue, string SecFieldName, string SecFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];
    }
    public DataTable GetDataTableSPWithTwoIntField(string strSPName, string FieldName, int FieldValue, string SecFieldName, int SecFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];
    }
    public DataTable GetDataTableSPWithTwoDateField(string strSPName, string FieldName, DateTime FieldValue, string SecFieldName, DateTime SecFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];
    }
    public DataTable GetDataTableSPWithOneIntAndTwoDateField(string strSPName, string FieldName, int FieldValue, string SecFieldName, DateTime SecFieldValue, string ThirdFieldName, DateTime ThirdFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);
        command.Parameters.Add(ThirdFieldName, ThirdFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];
    }
    public DataTable GetDataTableSPWithOneIntAndTwoDateAndOneStringField(string strSPName, string FieldName, int FieldValue, string SecFieldName, DateTime SecFieldValue, string ThirdFieldName, DateTime ThirdFieldValue, string ForthFieldName, string ForthFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);
        command.Parameters.Add(ThirdFieldName, ThirdFieldValue);
        command.Parameters.Add(ForthFieldName, ForthFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch (Exception ex)
        {
            closeconnect();
            throw ex;
        }
        return ds.Tables[0];
    }
    public DataTable GetDataTableSPWithOneIntOneStringAndTwoDateField(string strSPName, string FieldName, int FieldValue, string SecFieldName, string SecFieldValue, string ThirdFieldName, DateTime ThirdFieldValue, string ForthFieldName, DateTime ForthFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);
        command.Parameters.Add(ThirdFieldName, ThirdFieldValue);
        command.Parameters.Add(ForthFieldName, ForthFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];
    }
    public DataTable GetDataTableSPWithThreeField(string strSPName, string FieldName, int FieldValue, string SecFieldName, int SecFieldValue, string ThirdFieldName, int ThirdFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);
        command.Parameters.Add(ThirdFieldName, ThirdFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];
    }

    public DataTable GetDataTableSPWithThreeString(string strSPName, string FieldName, string FieldValue, string SecFieldName, string SecFieldValue, string ThirdFieldName, string ThirdFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);
        command.Parameters.Add(ThirdFieldName, ThirdFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];

    }
    public DataTable GetDataTableSPWithTwoField(string strSPName, string FieldName, int FieldValue, string SecFieldName, int SecFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];

    }

    public DataTable GetDataTableSPWithIDandField(string strSPName, string FieldName, int FieldValue, string SecFieldName, string SecFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];

    }
    public DataTable GetDataTableSPWithTwoStringField(string strSPName, string FieldName, string FieldValue, string SecFieldName, string SecFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];

    }
    public DataTable GetDataTableSPWithTwoIntAndOneString(string strSPName, string FieldName, int FieldValue, string SecFieldName, int SecFieldValue, string ThirdFieldName, string ThirdFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);
        command.Parameters.Add(ThirdFieldName, ThirdFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];

    }

    public DataTable GetDataTableSPWithOneIntAndTwoString(string strSPName, string FieldName, int FieldValue, string SecFieldName, string SecFieldValue, string ThirdFieldName, string ThirdFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);
        command.Parameters.Add(ThirdFieldName, ThirdFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];

    }

    public DataTable GetDataTableSPWithTwoIntAndTwoString(string strSPName, string FieldName, int FieldValue, string SecFieldName, int SecFieldValue, string ThirdFieldName, string ThirdFieldValue, string ForthFieldName, string ForthFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);
        command.Parameters.Add(ThirdFieldName, ThirdFieldValue);
        command.Parameters.Add(ForthFieldName, ForthFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch (Exception ex)
        {
            closeconnect();
            throw ex;
        }
        return ds.Tables[0];

    }

    public DataTable GetDataTableSPWithThreeIntAndTwoString(string strSPName, string FieldName, int FieldValue, string SecFieldName, int SecFieldValue, string ThirdFieldName, int ThirdFieldValue, string ForthFieldName, string ForthFieldValue, string FifthFieldName, string FifthFieldValue)
    {
        connect();
        SqlCommand command = new SqlCommand(strSPName, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, FieldValue);
        command.Parameters.Add(SecFieldName, SecFieldValue);
        command.Parameters.Add(ThirdFieldName, ThirdFieldValue);
        command.Parameters.Add(ForthFieldName, ForthFieldValue);
        command.Parameters.Add(FifthFieldName, FifthFieldValue);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];

    }

    public DataTable GetDataTableSPLogin(string str, string FieldName, string Name)
    {
        connect();
        SqlCommand command = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.AddWithValue(FieldName, Name);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds.Tables[0];

    }

    public void ExecuteQuery(string str)
    {
        connect();
        SqlCommand command = new SqlCommand(str, con);
        command.CommandType = System.Data.CommandType.Text;
        try
        {
            command.ExecuteNonQuery();
            closeconnect();
        }
        catch
        {
            closeconnect();
        }

    }
    public string ExecuteScaler(string str)
    {
        try
        {
            connect();
            SqlCommand command = new SqlCommand(str, con);
            command.CommandType = System.Data.CommandType.Text;
            string str1 = Convert.ToString(command.ExecuteScalar());
            closeconnect();
            return str1;

        }
        catch
        {
            closeconnect();
            return "";
        }


    }
    public Int16 ExecuteScalar(string str)
    {
        connect();
        Int16 Id;
        SqlCommand command = new SqlCommand(str, con);
        command.CommandType = System.Data.CommandType.Text;

        try
        {
            Id = Convert.ToInt16(command.ExecuteScalar());
        }
        catch
        {
            Id = 0;
            closeconnect();
        }
        closeconnect();
        return Id;

    }
    public Int32 ExecuteScalerSPCount(string str, string FieldName, string Name)
    {
        try
        {
            connect();
            SqlCommand command = new SqlCommand(str, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue(FieldName, Name);
            Int32 Id;

            Id = Convert.ToInt32(command.ExecuteScalar());
            closeconnect();
            return Id;

        }
        catch
        {
            closeconnect();
            return 0;
        }
    }
    public Int32 ExecuteScalerSPCountUnique(string strSPName, string strIdName, int cntIdValue, string strFieldName, string strFieldValue)
    {
        try
        {
            connect();
            SqlCommand command = new SqlCommand(strSPName, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue(strIdName, cntIdValue);
            command.Parameters.AddWithValue(strFieldName, strFieldValue);
            Int32 Id;

            Id = Convert.ToInt32(command.ExecuteScalar());
            closeconnect();
            return Id;

        }
        catch
        {
            closeconnect();
            return 111;
        }

    }
    public Int32 ExecuteScalerSPCountUniqueWith2Field(string strSPName, string strIdName, int cntIdValue, string strFieldName, string strFieldValue, string strIdname1, int cntIDValue1)
    {
        try
        {
            connect();
            SqlCommand command = new SqlCommand(strSPName, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue(strIdName, cntIdValue);
            command.Parameters.AddWithValue(strFieldName, strFieldValue);
            command.Parameters.AddWithValue(strIdname1, cntIDValue1);
            Int32 Id;

            Id = Convert.ToInt32(command.ExecuteScalar());
            closeconnect();
            return Id;

        }
        catch
        {
            closeconnect();
            return 111;
        }

    }
    public DataTable ExecuteProcedure(String ProcedureName)
    {
        try
        {
            connect();
            SqlCommand cmdProcudure = new SqlCommand();
            DataTable dtGeneral = new DataTable();
            SqlDataAdapter adpGeneral = new SqlDataAdapter();
            cmdProcudure.CommandText = ProcedureName;
            cmdProcudure.CommandType = CommandType.StoredProcedure;
            cmdProcudure.Connection = con;
            adpGeneral.SelectCommand = cmdProcudure;
            adpGeneral.Fill(dtGeneral);
            closeconnect();
            return dtGeneral;
        }
        catch (Exception ex)
        {
            closeconnect();
            return null;
        }
    }
    public DataTable ExecuteProcedureWithId(String ProcedureName, Int32 Id)
    {
        try
        {
            connect();
            SqlCommand cmdProcudure = new SqlCommand();
            DataTable dtGeneral = new DataTable();
            SqlDataAdapter adpGeneral = new SqlDataAdapter();
            cmdProcudure.CommandText = ProcedureName;
            cmdProcudure.CommandType = CommandType.StoredProcedure;
            cmdProcudure.Parameters.AddWithValue("@Id", Id);
            cmdProcudure.Connection = con;
            adpGeneral.SelectCommand = cmdProcudure;
            adpGeneral.Fill(dtGeneral);
            closeconnect();
            return dtGeneral;

        }
        catch (Exception ex)
        {
            closeconnect();
            return null;
        }
    }
    public string ReturnPageName(string strUrl)
    {
        System.IO.FileInfo page1 = new System.IO.FileInfo(strUrl);
        string sRet = page1.Name;
        return sRet;
    }
    public PagedDataSource GetPhotoAsPagedDataSource(int pageIndex, int pageSize, string PhotoType, int CategoryId)
    {
        // Get ALL of the Archives
        DataTable dt = new DataTable();
        // dt = GetDataTable("SELECT PhotoGalleryId, PhotoName, SmallImage, LargeImage, Comment, IsActive, EntryDate FROM PhotoGalleryMaster WHERE (IsActive = Yes) and PhotoType=" + PhotoType + " ORDER BY PhotoGalleryId DESC");
        if (CategoryId == 0)
        {
            dt = GetDataTable("SELECT * FROM PhotoMaster WHERE IsActive = 1 And PhotoType = " + PhotoType + " and PhotoCategoryId<>4");
        }
        else
        {
            dt = GetDataTable("SELECT * FROM PhotoMaster WHERE IsActive = 1 And PhotoType = " + PhotoType + " and PhotoCategoryId= " + CategoryId);
        }
        //if (dt.Rows.Count > 0)
        //{
        PagedDataSource pagedData = new PagedDataSource();
        DataView dv = new DataView(dt);
        pagedData.DataSource = dv;
        pagedData.AllowPaging = true;
        pagedData.CurrentPageIndex = pageIndex;
        pagedData.PageSize = pageSize;
        return pagedData;
        //}
        //else
        //{
        //    PagedDataSource pagedData = new PagedDataSource();
        //    DataView dv = new DataView(dt);
        //    pagedData.DataSource = dv;
        //    pagedData.AllowPaging = true;
        //    pagedData.CurrentPageIndex = 0;
        //    pagedData.PageSize = pageSize;
        //    return pagedData;
        //}
    }
    public int InsertNewsLettersUser(string strUserEmailId)
    {
        SqlCommand command = new SqlCommand();
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "SPInsertNewsLetterUserMaster";
        command.Connection = this.con;
        command.Parameters.AddWithValue("@UserEmailId", strUserEmailId);
        command.Parameters.AddWithValue("@EntryDate", DateTime.Now);
        SqlParameter retpara = new SqlParameter();
        retpara.Direction = ParameterDirection.ReturnValue;
        command.Parameters.Add(retpara);
        int nRet = 0;
        this.connect();
        command.ExecuteNonQuery();
        nRet = Convert.ToInt16(retpara.Value);
        this.closeconnect();
        return nRet;
    }

    public void InsertLogdetail(int userid, string userevent, string sessionid)
    {
        try
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SPInsertLogdetailMaster";
            command.Connection = this.con;

            command.Parameters.AddWithValue("@UserId", userid);
            command.Parameters.AddWithValue("@UserEvent", userevent);
            command.Parameters.AddWithValue("@SessionId", sessionid);

            string HostName = Dns.GetHostName();
            string clientipaddress = Dns.GetHostAddresses(HostName).GetValue(0).ToString();

            //string clientIpAddr = "";
            //clientIpAddr = Request.ServerVariables["REMOTE_ADDR"].ToString();

            command.Parameters.AddWithValue("@IpAddress", clientipaddress);

            this.connect();
            command.ExecuteNonQuery();
            this.closeconnect();
        }
        catch
        {
        }
    }
    public void InsertErrorLogDetail(int intUserId, string strErrorPage, string strErrorEvent, string strMessage)
    {
        try
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SPInsertErrorLogMaster";
            command.Connection = this.con;

            string HostName = Dns.GetHostName();
            string clientIPAddress = Dns.GetHostAddresses(HostName).GetValue(0).ToString();

            command.Parameters.AddWithValue("@UserId", intUserId);
            command.Parameters.AddWithValue("@IpAddress", clientIPAddress);
            command.Parameters.AddWithValue("@ErrorPage", strErrorPage);
            command.Parameters.AddWithValue("@ErrorEvent", strErrorEvent);
            command.Parameters.AddWithValue("@ErrorMessage", strMessage);

            this.connect();
            command.ExecuteNonQuery();
            this.closeconnect();
        }
        catch
        {
        }
    }
    public int ExecuteNonQueryWithId(String procedureName, List<SqlParameter> param)
   {
        int iRet = 0;
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = procedureName;

        cmd.Parameters.Clear();
        if (param != null)
        {
            foreach (SqlParameter p in param)
            {
                cmd.Parameters.Add(p);
            }
        }

        SqlParameter retValReference = new SqlParameter();
        retValReference.Direction = ParameterDirection.ReturnValue;
        cmd.Parameters.Add(retValReference);

        try
        {
            connect();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            iRet = Convert.ToInt32(retValReference.Value);
            return iRet;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            closeconnect();
        }
    }
    public void ClearControls(Page p)
    {
        ArrayList controls = GetControls(p.Controls);
        for (int i = 0; i <= (controls.Count - 1); i++)
        {
            Control control = (Control)controls[i];

            if (control.GetType().ToString().Equals("System.Web.UI.WebControls.TextBox"))
            {
                ((TextBox)control).Text = "";
            }
            if (control.GetType().ToString().Equals("System.Web.UI.WebControls.CheckBox"))
            {
                ((CheckBox)control).Checked = false;
            }
            if (control.GetType().ToString().Equals("System.Web.UI.WebControls.RadioButton"))
            {
                ((RadioButton)control).Checked = false;
            }
            if (control.GetType().ToString().Equals("System.Web.UI.WebControls.DropDownList"))
            {
                if (((DropDownList)control).Items.Count > 0)
                {
                    ((DropDownList)control).SelectedIndex = 0;
                }
            }
            if (control.GetType().ToString().Equals("System.Web.UI.WebControls.CheckBoxList"))
            {
                if (((CheckBoxList)control).Items.Count > 0)
                {
                    ((CheckBoxList)control).SelectedIndex = 0;
                }
            }
            if (control.GetType().ToString().Equals("System.Web.UI.WebControls.RadioButtonList"))
            {
                if (((RadioButtonList)control).Items.Count > 0)
                {
                    ((RadioButtonList)control).SelectedIndex = 0;
                }
            }
        }
    }
    public ArrayList GetControls(ControlCollection cc)
    {
        ArrayList al = new ArrayList();
        AddControls(ref al, cc);
        return al;
    }

    private void AddControls(ref ArrayList al, ControlCollection cc)
    {
        foreach (Control control in cc)
        {
            al.Add(control);
            if (control.Controls.Count > 0)
            {
                AddControls(ref al, control.Controls);
            }
        }
    }

    public DataSet GetDataTableSPWith2Fileds(string str, string FieldName, int Id)
    {
        connect();
        SqlCommand command = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add(FieldName, Id);

        da.SelectCommand = command;
        try
        {
            da.Fill(ds, "Generalised");
            closeconnect();
        }
        catch
        {
            closeconnect();
        }
        return ds;

    }

    public byte[] ResizeSmallImage(FileUpload Fup, int widthPerc, int HeightPerc)
    {
        MemoryStream ms = new MemoryStream((byte[])Fup.FileBytes);

        System.Drawing.Image Original = System.Drawing.Image.FromStream(ms);



        int height = Original.Height;
        int width = Original.Width;
        if (width <= 150)
        {
            widthPerc = width;
        }
        if (height <= 100)
        {
            HeightPerc = height;
        }
        System.Drawing.Bitmap newPic = new System.Drawing.Bitmap(widthPerc, HeightPerc);
        System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(newPic);
        gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
        gr.DrawImage(Original, 0, 0, widthPerc, HeightPerc);
        MemoryStream ms1 = new MemoryStream();
        newPic.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
        gr.Dispose();
        newPic.Dispose();
        Original.Dispose();
        return ms1.ToArray();

    }

    public string StringToAscii(string strValue)
    {
        System.Text.StringBuilder encValue = new System.Text.StringBuilder(strValue.Length * 6);
        strValue = strValue.Replace("&nbsp;", " ");
        strValue = strValue.Replace("&quot;", "\"");
        strValue = strValue.Replace("&lt;", "<");
        strValue = strValue.Replace("&gt;", ">");
        strValue = strValue.Replace("&amp;", "&");
        strValue = strValue.Replace("&rdquo;", "\"");
        strValue = strValue.Replace("&ldquo;", "\"");
        strValue = strValue.Replace("&lsquo;", "\"");

        for (int i = 0; i < strValue.Length; i++)
        {
            if (strValue[i].ToString() == "<")
            {
                int tagindex = strValue.IndexOf(">", i);
                String htmltag = strValue.Substring(i, (tagindex - i) + 1);
                encValue.Append(htmltag);
                i = tagindex;
            }
            else
            {
                encValue.Append("&#");
                encValue.Append((Convert.ToInt32(strValue[i])));
                encValue.Append(";");
            }
        }
        encValue = encValue.Replace("&#32;", " ");
        encValue = encValue.Replace("&#13;", " ");
        encValue = encValue.Replace("&#10;", " ");
        return encValue.ToString().Trim();

    }

    public DataSet getDataSet(String SPName, SqlParameter[] param)
    {
        try
        {
            connect();
            SqlCommand cmdProcudure = new SqlCommand();
            cmdProcudure.CommandText = SPName;
            cmdProcudure.CommandType = CommandType.StoredProcedure;
            cmdProcudure.Connection = con;
            foreach (SqlParameter p in param)
            {
                cmdProcudure.Parameters.Add(p);
            }
            DataSet dsGeneral = new DataSet();
            SqlDataAdapter adpGeneral = new SqlDataAdapter(cmdProcudure);
            adpGeneral.Fill(dsGeneral);
            closeconnect();
            return dsGeneral;
        }
        catch (Exception ex)
        {
            closeconnect();
            return null;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
            {
                closeconnect();
            }
        }
    }

    public object executeQuery(string SPName, SqlParameter[] param, string returnParam)
    {
        object o = null;

        try
        {
            SqlCommand cmd = new SqlCommand()
            {
                CommandText = SPName,
                CommandType = CommandType.StoredProcedure,
                Connection = con,
            };
            foreach (SqlParameter p in param)
            {
                cmd.Parameters.Add(p);
            }
            connect();
            cmd.ExecuteNonQuery();
            o = cmd.Parameters[returnParam].Value;
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            closeconnect();
        }
        return o;
    }


    public DataSet getdatasetvalue(String SPName)
    {
        try
        {
            connect();
            SqlCommand cmdProcudure = new SqlCommand();
            cmdProcudure.CommandText = SPName;
            cmdProcudure.CommandType = CommandType.StoredProcedure;
            cmdProcudure.Connection = con;           
            DataSet dsGeneral = new DataSet();
            SqlDataAdapter adpGeneral = new SqlDataAdapter(cmdProcudure);
            adpGeneral.Fill(dsGeneral);
            closeconnect();
            return dsGeneral;
        }
        catch (Exception ex)
        {
            closeconnect();
            return null;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
            {
                closeconnect();
            }
        }
    }

//jignesh

    public DataTable getDataTablej(String SPName, SqlParameter[] param)
    {
        try
        {
            connect();
            SqlCommand cmdProcudure = new SqlCommand();
            cmdProcudure.CommandText = SPName;
            cmdProcudure.CommandType = CommandType.StoredProcedure;
            cmdProcudure.Connection = con;
            foreach (SqlParameter p in param)
            {
                cmdProcudure.Parameters.Add(p);
            }
            DataTable dsGeneral = new DataTable();
            SqlDataAdapter adpGeneral = new SqlDataAdapter(cmdProcudure);
            adpGeneral.Fill(dsGeneral);
            closeconnect();
            return dsGeneral;
        }
        catch (Exception ex)
        {
            closeconnect();
            return null;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
            {
                closeconnect();
            }
        }
    }

}
