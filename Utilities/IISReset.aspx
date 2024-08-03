<%@ Page Language="C#" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server" language="C#">   
    void Page_Load(object sender, System.EventArgs e)
    {
        using (System.Diagnostics.Process process = new System.Diagnostics.Process())
        {
            process.StartInfo = new System.Diagnostics.ProcessStartInfo();
            process.StartInfo.FileName = "IISReset.exe";
            process.StartInfo.Arguments = String.Empty;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
        }
        //Unload AppDomain so IISReset will not wait on us.
        System.Web.HttpRuntime.UnloadAppDomain();
    } 
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset IIS</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Resetting IIS on Box, please wait....    
    </div>
    </form>
</body>
</html>