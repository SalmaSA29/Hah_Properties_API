using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Collections.Generic;

public class General
{
    public static void SendEmailToNotifyRequest(string All, DateTime X, string link, string User_Name, string Manager_Email, string User_Title, string User_Department, string Service_Name, string PageName, string Request_No, string Service_ID, string approval, string serial)
    {
        //string Email = General.ExecuteScalar("select Email from TWebWF_Employee_Data where User_HR_Code='" + User_ID + "'").ToString();
        //string Service_Name = General.ExecuteScalar("select Service_Name from TWEBWF_Service where Service_ID='" + Service_ID + "'").ToString();
        //string PageName = General.ExecuteScalar("select PageName from TWEBWF_Service where Service_ID='" + Service_ID + "'").ToString();
        //string requester = General.ExecuteScalar("select Name from TWebWF_Employee_Data where User_HR_Code='" + User + "'").ToString();
        //string jobtitle = General.ExecuteScalar("select t.Title_Name from TWebWF_Employee_Data d inner join TWEBWF_Title t on d.Title_ID = t.Title_ID where User_HR_Code='" + User + "'").ToString();
        //string Depart = General.ExecuteScalar("select pr.ProjectName from TWebWF_Employee_Data d inner join TWEBWF_Projects pr on d.Location_ID = pr.Project_ID  where User_HR_Code='" + User + "'").ToString();
        string Subject = "HAH Portal : " + Service_Name + " Request No. " + Request_No;
        string Body = @"<p style='font-size:15px;' > Dear Sir,</p> " +
        "<p style = 'font-size:15px ;' ></p> " +
        "<p style = 'font-size:15px ;' ><b> Request Date: </b> " + X + " </p> " +
        "<p style = 'font-size:15px ;' ><b> Request Type: </b> " + Service_Name + " </p> " +
        "<p style = 'font-size:15px ;' ><b> Requester: </b>" + User_Name + "  </p> " +
        "<p style = 'font-size:15px ;' ><b> Job Title:</b> " + User_Title + " </p > " +
        "<p style = 'font-size:15px ;' ><p><b>Description:  </b> " + All + "</p > " +
        "<p style = 'font-size:15px ;' ><b> Department:</b>  " + User_Department + "</p><a href = " + link + "> View more </a>" +
        "<p style = 'font-size:15px ;' >&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</br>" +
        "<a style = 'color:White;background-color:#ff3300;width:82px;height:26px;margin-right: 23px;text-align:center;padding: 8px 50px;text-decoration-line:none;' href = https://portal.hassanallam.com/Public/RequestApprove.aspx?stype=" + Service_ID + "&FormID=" + Request_No + "&approval=" + approval + "&serial=" + serial + "&Approve=0> Reject </a>" +
        "<a style = 'color:White;background-color:#1acc59;width:82px;height:26px;margin-right: 23px;text-align:center;padding: 8px 50px;text-decoration-line:none;' href = https://portal.hassanallam.com/Public/RequestApprove.aspx?stype=" + Service_ID + "&FormID=" + Request_No + "&approval=" + approval + "&serial=" + serial + "&Approve=1>Accept</a>" +
        "</p></br><p> ********************************<p>" +
         "<p style = 'font-size:15px ;' > Please don't respond to this e-mail. For any inquiry or support please contact: </p><p style='font - size:15px; face = tahoma' > itsh.sd@Hassanallam.com </p> <p> <p style='font-size:20px; face = tahoma' > <b> HAH Portal- Self Service</b> </p>";


        if (Service_ID == "HAT-IT-FRM-03") // Equipment
        {
            Body = "<b> <p style='font-size:15px ; face=tahoma' >" + Service_Name + " Request:</b> </p> <p><p><p style='font-size:15px ; face=tahoma' > You have a request pending your approval or rejection. To view the request, please follow   <a href='http://portal.hassanallam.com/Apps/" + PageName + "?stype=" + Service_ID + "&FormID=" + Request_No + "&approval=" + approval + "&serial=" + serial + "&ITOperations=1'> Request #" + Request_No + "</a>" + "</td> </p> <p>********************************<p><p style='font-size:15px ; face=tahoma' > Please don't respond to this e-mail. For any inquiry or support please contact: </p><p style='font-size:15px ; face=tahoma' > itsh.sd@Hassanallam.com </p> <p> <p style='font-size:20px ; face=tahoma' > <b> HAH Portal- Self Service</b> </p>";
        }
        //DataTable DT = General.ToTable("[GetInboxDetail] '" + User_ID + "','" + Service_ID + "','" + Request_No + "' ");
        //string All = "";
        //string createdate = "";
        //string link = "";
        //if (DT.Rows.Count > 0)
        //{
        //    if (DT.Rows[0]["All"].ToString() != "")
        //    {
        //        All = DT.Rows[0]["All"].ToString();
        //    }
        //    if (DT.Rows[0]["CreateDate"].ToString() != "")
        //    {
        //        createdate = DT.Rows[0]["CreateDate"].ToString();
        //    }
        //    if (DT.Rows[0]["link"].ToString() != "")
        //    {
        //        link = DT.Rows[0]["link"].ToString();
        //    }
        //}
        //string Body1 = @"<p style='font-size:15px;' > Dear Sir,</p> " +
        //        "<p style = 'font-size:15px ;' ></p> " +
        //        "<p style = 'font-size:15px ;' ><b> Request Date: </b> " + createdate + " </p> " +
        //        "<p style = 'font-size:15px ;' ><b> Request Type: </b> " + Service_Name + " </p> " +
        //        "<p style = 'font-size:15px ;' ><b> Requester: </b>" + requester + "  </p> " +
        //        "<p style = 'font-size:15px ;' ><b> Job Title:</b> " + jobtitle + " </p > " +
        //        "<p style = 'font-size:15px ;' ><p><b>Description:  </b> " + All + "</p > " +
        //        "<p style = 'font-size:15px ;' ><b> Department:</b>  " + Depart + " </p> <a href =" + link + ">Viewmore</a>";
        //string Body2 = "";
        //switch (Service_ID)
        //{
        //    case "HAH-HR-FRM-04":
        //        string Responsible = General.ExecuteScalar("SELECT EMP.Name FROM TWEBWF_Vacation V INNER JOIN TWebWF_Employee EMP ON V.Responsible = EMP.User_HR_Code WHERE V.Request_No = '" + Request_No + "'").ToString();
        //        Body2 = "<p style = 'font-size:15px ;' ><b> Replacement:</b>  " + Responsible + " </p> ";
        //        break;
        //}
        //string Body3 = "<p style = 'font-size:15px ;' >&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</br>" +
        //               "<a style = 'color:White;background-color:#ff3300;width:82px;height:26px;margin-right: 23px;text-align:center;padding: 8px 50px;text-decoration-line:none;' href = https://portal.hassanallam.com/Public/RequestApprove.aspx?stype=" + Service_ID + "&FormID=" + Request_No + "&approval=" + approval + "&serial=" + serial + "&Approve=0> Reject </a>" +
        //               "<a style = 'color:White;background-color:#1acc59;width:82px;height:26px;margin-right: 23px;text-align:center;padding: 8px 50px;text-decoration-line:none;' href = https://portal.hassanallam.com/Public/RequestApprove.aspx?stype=" + Service_ID + "&FormID=" + Request_No + "&approval=" + approval + "&serial=" + serial + "&Approve=1>Accept</a>" +
        //               "</p></br><p> ********************************<p>" +
        //               "<p style = 'font-size:15px ;' > Please don't respond to this e-mail. For any inquiry or support please contact: </p><p style='font - size:15px; face = tahoma' > itsh.sd@Hassanallam.com </p> <p> <p style='font-size:20px; face = tahoma' > <b> HAH Portal- Self Service</b> </p>";
        #region set parameter
        string smtpServer = "smtp.office365.com";
        string smtpUsername = "portaladmin@Hassanallam.com";
        string smtpPassword = "956GQLTyV&guTix#t2$qLsqEmG!%@dD!mwJa%tWEKJL^##5bwCp%^hUw%T%LgQ6JQ$Quo%4hJK*@dPf6k4!tTN";
        string EmailTo = Manager_Email;
        string MailSubject = Subject;
        string MailBody = Body;
        #endregion
        SmtpClient smtpMail = new SmtpClient();
        MailMessage message = new MailMessage();
        try
        {
            smtpMail.Host = smtpServer;
            //smtpMail.EnableSsl = true;
            smtpMail.UseDefaultCredentials = false;
            smtpMail.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
            //fetching credentials
            MailAddress fromAddress = new MailAddress("portaladmin@Hassanallam.com", "Portal Notification");
            //Set the sender address of the mail message
            message.From = fromAddress;
            message.Sender = fromAddress;
            message.To.Add(EmailTo);
            message.Subject = MailSubject;
            message.Body = MailBody;
            message.IsBodyHtml = true;
            smtpMail.DeliveryMethod = SmtpDeliveryMethod.Network;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            smtpMail.EnableSsl = true;
            smtpMail.Port = 587; // You can use Port 25 if 587 is blocked
            /////////////////////////////////////////////////////
            smtpMail.Send(message);
        }
        catch (Exception ex)
        {

        }
    }
    public static void SendEmailToNotifyResult(string Email, string Request_No, string Service_Name, string Results, string comments, string CCEmail = "")
    {
        string Subject = Service_Name + " . Request No. " + Request_No;
        string Body = "<b> <p style='font-size:15px ; face=tahoma' >" + Service_Name + " :</b> </p>";
        Body = Body + "<p style='font-size:15px ; face=tahoma' > Your request has been . " + Results + "  	&nbsp;  	&nbsp;" + comments + " </p> <p>********************************<p><p style='font-size:15px ; face=tahoma' > Please don't respond to this e-mail. For any inquiry or support please contact: </p><p style='font-size:15px ; face=tahoma' > itsh.sd@Hassanallam.com </p> <p> <p style='font-size:20px ; face=tahoma' > <b> HAH Portal- Self Service</b> </p>";
        #region set parameter
        string smtpServer = "smtp.office365.com";
        string smtpUsername = "portaladmin@Hassanallam.com";
        string smtpPassword = "956GQLTyV&guTix#t2$qLsqEmG!%@dD!mwJa%tWEKJL^##5bwCp%^hUw%T%LgQ6JQ$Quo%4hJK*@dPf6k4!tTN";
        string EmailTo = Email;
        string MailSubject = Subject;
        string MailBody = Body;

        #endregion
        string flah = "";
        SmtpClient smtpMail = new SmtpClient();
        MailMessage message = new MailMessage();
        try
        {
            smtpMail.Host = smtpServer;
            //smtpMail.EnableSsl = true;
            smtpMail.UseDefaultCredentials = false;
            smtpMail.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
            //fetching credentials
            MailAddress fromAddress = new MailAddress("portaladmin@Hassanallam.com", "Portal Notification");
            //Set the sender address of the mail message
            message.From = fromAddress;
            message.Sender = fromAddress;
            message.To.Add(EmailTo);
            if (CCEmail != "")
            {
                message.CC.Add(CCEmail);
            }
            message.Subject = MailSubject;
            message.Body = MailBody;

            message.IsBodyHtml = true;
            smtpMail.DeliveryMethod = SmtpDeliveryMethod.Network;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            smtpMail.EnableSsl = true;

            smtpMail.Port = 587; // You can use Port 25 if 587 is blocked

            ////////////////////////////////


            /////////////////////////////////////////////////////

            smtpMail.Send(message);

        }

        catch (Exception ex)
        {

        }

    }
    //public int PreviousPermission(string Request_HR_Code)
    //{
    //    int CurDay = DateTime.Now.Day;
    //    string FromDate = "";
    //    string ToDate = "";
    //    if (CurDay >= 1 && CurDay < 16)
    //    {
    //        int CurMonth = 0;
    //        if (DateTime.Now.Month != 1)
    //        {
    //            CurMonth = DateTime.Now.Month - 1;
    //        }
    //        if (CurMonth == 0)
    //        {
    //            CurMonth = 12;
    //        }
    //        if (CurMonth == 12)
    //        {
    //            FromDate = (int.Parse(DateTime.Now.Year.ToString()) - 1).ToString() + "-" + CurMonth + "-" + "16";
    //        }
    //        else
    //        {
    //            FromDate = DateTime.Now.Year.ToString() + "-" + CurMonth + "-" + "16";
    //        }
    //        ToDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month + "-" + "15";
    //    }
    //    else if (CurDay >= 16 && CurDay < 31)
    //    {
    //        int ToMonth = DateTime.Now.Month + 1;
    //        if (ToMonth == 13)
    //        {
    //            ToMonth = 1;
    //        }
    //        FromDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month + "-" + "16";
    //        if (ToMonth == 12)
    //        {
    //            ToDate = (int.Parse(DateTime.Now.Year.ToString()) + 1).ToString() + "-" + ToMonth + "-" + "15";
    //        }
    //        else
    //        {
    //            ToDate = DateTime.Now.Year.ToString() + "-" + ToMonth + "-" + "15";
    //        }
    //    }
    //}


    public static void SendEmail(string email, string reqno)
    {
    
        string Subject = "EDMS : Document managment system Request No. " + reqno;
        string Body = @"<p style='font-size:15px;' > Dear Sir,</p> " +
"</p><a href ='https://apps.hassanallam.com/document-management/document-inbox' > You have received a new Workflow Transmittal: WF- "+ reqno + " </a>" +
"</br></br></br>This email is automatically generated by the EDMS.</br>If you need assistance, please contact our IT Department</br></br>Regards,</br>Document Control Team"
;
        #region set parameter
        string smtpServer = "smtp.office365.com";
        string smtpUsername = "EDMSadmin@hassanallam.com";
        string smtpPassword = "e@eB0N$GKF%qD7qr";
        string EmailTo = email;
        string MailSubject = Subject;
        string MailBody = Body;
        #endregion
        SmtpClient smtpMail = new SmtpClient();
        MailMessage message = new MailMessage();
        try
        {
            smtpMail.Host = smtpServer;
            //smtpMail.EnableSsl = true;
            smtpMail.UseDefaultCredentials = false;
            smtpMail.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
            //fetching credentials
            MailAddress fromAddress = new MailAddress("EDMSadmin@hassanallam.com", "EDMS Notification");
            //Set the sender address of the mail message
            message.From = fromAddress;
            message.Sender = fromAddress;
            message.To.Add(EmailTo);
            message.Subject = MailSubject;
            message.Body = MailBody;
            message.IsBodyHtml = true;
            smtpMail.DeliveryMethod = SmtpDeliveryMethod.Network;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            smtpMail.EnableSsl = true;
            smtpMail.Port = 587; // You can use Port 25 if 587 is blocked
            /////////////////////////////////////////////////////
            smtpMail.Send(message);
        }
        catch (Exception ex)
        {

        }
    }

    public static void SendEmaildistribution(string email,int docID)
    {

        string Subject = "EDMS : Document managment system";
        string Body = @"<p style='font-size:15px;' > Dear Sir,</p> " +
"</p><a href ='https://apps.hassanallam.com/document-management/document-lookup/details/"+docID+"'> You have received a New Document </a>" +
"</br></br></br>This email is automatically generated by the EDMS.</br>If you need assistance, please contact our IT Department</br></br>Regards,</br>Document Control Team"
;
        #region set parameter
        string smtpServer = "smtp.office365.com";
        string smtpUsername = "EDMSadmin@hassanallam.com";
        string smtpPassword = "e@eB0N$GKF%qD7qr";
        string EmailTo = email;
        string MailSubject = Subject;
        string MailBody = Body;
        #endregion
        SmtpClient smtpMail = new SmtpClient();
        MailMessage message = new MailMessage();
        try
        {
            smtpMail.Host = smtpServer;
            //smtpMail.EnableSsl = true;
            smtpMail.UseDefaultCredentials = false;
            smtpMail.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
            //fetching credentials
            MailAddress fromAddress = new MailAddress("EDMSadmin@hassanallam.com", "EDMS Notification");
            //Set the sender address of the mail message
            message.From = fromAddress;
            message.Sender = fromAddress;
            message.To.Add(EmailTo);
            message.Subject = MailSubject;
            message.Body = MailBody;
            message.IsBodyHtml = true;
            smtpMail.DeliveryMethod = SmtpDeliveryMethod.Network;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            smtpMail.EnableSsl = true;
            smtpMail.Port = 587; // You can use Port 25 if 587 is blocked
            /////////////////////////////////////////////////////
            smtpMail.Send(message);
        }
        catch (Exception ex)
        {

        }
    }
    public static void SendEmailGeneric(string subject, string body, List<string> to, List<string> cc)
    {

        #region set parameter
        string smtpServer = "smtp.office365.com";
        string smtpUsername = "portaladmin@Hassanallam.com";
        string smtpPassword = "956GQLTyV&guTix#t2$qLsqEmG!%@dD!mwJa%tWEKJL^##5bwCp%^hUw%T%LgQ6JQ$Quo%4hJK*@dPf6k4!tTN";
        string MailSubject = subject;
        #endregion
        SmtpClient smtpMail = new SmtpClient();
        MailMessage message = new MailMessage();
        try
        {
            smtpMail.Host = smtpServer;
            //smtpMail.EnableSsl = true;
            smtpMail.UseDefaultCredentials = false;
            smtpMail.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
            //fetching credentials
            MailAddress fromAddress = new MailAddress("portaladmin@Hassanallam.com", "Portal Notification");
            //Set the sender address of the mail message
            message.From = fromAddress;
            message.Sender = fromAddress;

            for (int i = 0; i < to.Count; i++)
            {
                message.To.Add(to[i]);
            }
            
            for (int i = 0; i < cc.Count; i++)
            {
                message.CC.Add(cc[i]);
            }

            message.Subject = MailSubject;
            message.Body = body;
            message.IsBodyHtml = true;
            smtpMail.DeliveryMethod = SmtpDeliveryMethod.Network;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            smtpMail.EnableSsl = true;
            smtpMail.Port = 587; // You can use Port 25 if 587 is blocked
            /////////////////////////////////////////////////////
            smtpMail.Send(message);
        }
        catch (Exception ex)
        {

        }
    }

}