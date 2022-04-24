<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin home.aspx.cs" Inherits="GUCera.admin_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <style>
         body {
             background-color: #F0F8FF;
         }
         h1 {
            color:white;
            
            font-family: sans-serif;
            
         }
       
         .navbar {
           background-color: #4682B4;
           width: 300px;
           position: absolute;
           left: 0;
           top: 0;
           height: 100%;
           text-align: center;
           overflow: hidden;
          }
         .navbar, .navbar ul {
           padding: 0;
           margin: 0;
           }
         .navbar a {
           color: white;
           text-decoration: none;
           font-size: 20px;
           -webkit-transition: all .5s ease;
            -moz-transition: all .5s ease;
          -o-transition: all .5s ease;
         -ms-transition: all .5s ease;
          transition: all .5s ease;
          }
         .navbar ul a:hover {
          font-size: 25px;
          color: #fffc63;
          }
          .navbar ul {
          list-style: none;
          margin-top: 5vh;
           }
          .navbar ul li {
           margin-bottom: 5vh;
           }
          .parent {
            display: grid;
            grid-template-columns: repeat(5, 1fr);
            grid-template-rows: repeat(5, 1fr);
            grid-column-gap: 0px;
            grid-row-gap: 0px;
            background-color: #4682B4;
            
            text-align: center;
            height: 100px;
            margin-top:0px;
            position: fixed; right: 0; left: 0; top: 0;
           }

           .div1 { grid-area: 1 / 1 / 2 / 6; }
    </style>
    <div class="parent">
     <div class="div1">
         <h1>Admin Home</h1>

     </div>
    </div>
     

    <form id="form1" runat="server">
        <nav class="navbar">
  <a href="#" id="navbar_icon">&#9776</a>
  <ul class="list">
    <li><a href="#">Home</a></li>
    <li><a href="addmobile.aspx"> add my mobile number</a></li>
    <li><a href="allcourse.aspx"> All Courses</a></li>
    <li><a href="notyet.aspx">Pending Courses</a></li>
    <li><a href="promocode.aspx"> Create Promocode</a></li>
     <li><a href="studentpromo.aspx">Issue Promocode to student</a></li>
      </form>

  </ul>
</nav>
       
       
        
       
        
        
    
</body>
</html>
