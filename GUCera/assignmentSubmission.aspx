<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignmentSubmission.aspx.cs" Inherits="GUCera.assignmentSubmission" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
         .rtable {
  /*!
  // IE needs inline-block to position scrolling shadows otherwise use:
  // display: block;
  // max-width: min-content;
  */
  display: inline-block;
  vertical-align: top;
  max-width: 100%;
  
  overflow-x: auto;
  
  // optional - looks better for small cell values
  white-space: nowrap;

  border-collapse: collapse;
  border-spacing: 0;
}

.rtable,
.rtable--flip tbody {
  // optional - enable iOS momentum scrolling
  -webkit-overflow-scrolling: touch;
  
  // scrolling shadows
  background: radial-gradient(left, ellipse, rgba(0,0,0, .2) 0%, rgba(0,0,0, 0) 75%) 0 center,
              radial-gradient(right, ellipse, rgba(0,0,0, .2) 0%, rgba(0,0,0, 0) 75%) 100% center;
  background-size: 10px 100%, 10px 100%;
  background-attachment: scroll, scroll;
  background-repeat: no-repeat;
}

// change these gradients from white to your background colour if it differs
// gradient on the first cells to hide the left shadow
.rtable td:first-child,
.rtable--flip tbody tr:first-child {
  background-image: linear-gradient(to right, rgba(255,255,255, 1) 50%, rgba(255,255,255, 0) 100%);
  background-repeat: no-repeat;
  background-size: 20px 100%;
}

// gradient on the last cells to hide the right shadow
.rtable td:last-child,
.rtable--flip tbody tr:last-child {
  background-image: linear-gradient(to left, rgba(255,255,255, 1) 50%, rgba(255,255,255, 0) 100%);
  background-repeat: no-repeat;
  background-position: 100% 0;
  background-size: 20px 100%;
}

.rtable th {
  font-size: 11px;
  text-align: left;
  text-transform: uppercase;
  background: #f2f0e6;
}

.rtable th,
.rtable td {
  padding: 6px 12px;
  border: 1px solid #d9d7ce;
}

.rtable--flip {
  display: flex;
  overflow: hidden;
  background: none;
}

.rtable--flip thead {
  display: flex;
  flex-shrink: 0;
  min-width: min-content;
}

.rtable--flip tbody {
  display: flex;
  position: relative;
  overflow-x: auto;
  overflow-y: hidden;
}

.rtable--flip tr {
  display: flex;
  flex-direction: column;
  min-width: min-content;
  flex-shrink: 0;
}

.rtable--flip td,
.rtable--flip th {
  display: block;
}

.rtable--flip td {
  background-image: none !important;
  // border-collapse is no longer active
  border-left: 0;
}

// border-collapse is no longer active
.rtable--flip th:not(:last-child),
.rtable--flip td:not(:last-child) {
  border-bottom: 0;
}
#Label4{
    font-family: sans-serif;
   font-size: 20px;
    color:red;

}
        h1{
            font-family: sans-serif;
            font-size: 50px;
            margin: 0 0 10px 0;
            color: #4682B4;

        }
        .label,#Label1,#Label2,#Label3 {
            font-family: sans-serif;
            font-size: 20px;
            margin: 0 0 10px 0;
            color: #4682B4;
        }
         .submit {
           width: 200px;
           color: white;
           background-color: 	#D3D3D3;
          font-size: 20px;
          }

         .submit:hover {
         box-shadow: 15px 15px 15px 5px rgba(78, 72, 77, 0.219);
         transform: translateY(-3px);
          width: 300px;
          border-top: 5px solid #0e3750;
          border-radius: 0%;
         }
         

         #card:hover {
           box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
          }

          .container {
            padding: 2px 16px;
           }
          #card{
              margin-top:50px;
              margin-left:235px;
              box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
              transition: 0.3s;
              width: 60%;
              border-radius: 5px;
             background-color: #F0F8FF;
            
          }
          body{
             background-color: #B0C4DE;
             
          }
         #form1{
             text-align: center;
         }

      
          
       
    </style>
    <div id="card">
    <form id="form1" runat="server">
        <h1>Submit Assignment</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Course ID :"></asp:Label><br />
            <asp:TextBox ID="courseId" runat="server"></asp:TextBox><br />
           
            <asp:Label ID="Label2" runat="server" Text="Enter assignment number : "></asp:Label><br />
            <asp:TextBox ID="no" runat="server"></asp:TextBox><br />
        </div>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Choose sssignment type : "></asp:Label>
            <asp:RadioButtonList id="type" align="center" runat="server" style="height: 80px">
                
                 <asp:ListItem  Text="Quiz"/>
                 <asp:ListItem  Text="Project"/>
                 <asp:ListItem  Text="Exam"/>
               
            </asp:RadioButtonList>

            <asp:Button ID="submit" CssClass="submit" runat="server" Text="Submit" OnClick="submit_Click" /><br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </p>
    </form>
        </div>
</body>
</html>
