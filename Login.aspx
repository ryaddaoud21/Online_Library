﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BiB.Login" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Un Peu+ | Login</title>
    <link href="Style/layout.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" integrity="sha512-+4zCK9k+qNFUR5X+cKL9EIR+ZOhtIloNl9GIKS57V1MyNsYpYcUrUeQc9vNfzsWfV28IaLL3i96P9sdNyeRssA==" crossorigin="anonymous" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
</head>

<body>

    <!--Navbar-->

    <nav class="navbar">
        <div class="navbar__container">
            <a href="#home" id="navbar__logo">UN PEU PLUS +</a>
            <div class="navbar__toggle" id="mobile-menu">
                <span class="bar"></span>
                <span class="bar"></span>
                <span class="bar"></span>
            </div>
            <ul class="navbar__menu">
                <li class="navbar__item">
                    <a href="WebForm4.aspx" class="navbar__links">Acceuil</a>
                </li>
                <li class="navbar__item">
                    <a href="ListDeLivre.aspx" class="navbar__links">Nouveautes</a>
                </li>
                <li class="navbar__item">
                    <a href="Panier.aspx" class="navbar__links"> Panier&nbsp;<i class="fa fa-shopping-cart"></i></a>
                </li>
                <li class="navbar__item">
                    <a href="SignIn.aspx" class="navbar__links">Inscription </a>
                </li>
                <li class="navbar__btn">
                    <a href="Login.aspx" class="button">Connexion&nbsp;<i class="fa fa-user"></i> </a>
                </li>
            </ul>
        </div>
    </nav>

    <div class="menu" id="menu">
        <div class="main__img--cards"></div>

        <h1> Connexion</h1>
        <div class="rey">
            <form action="" method="post" runat="server">

                <div class="container">
                    <label for="uname"><b>Nom d'utilisateur</b></label>
                   <asp:TextBox ID="TextBox1" runat="server" type="text" placeholder="Enter Username" name="uname"></asp:TextBox>


                    <label for="psw"><b>Motdepass</b></label>
                     <asp:TextBox ID="TextBox2" runat="server"  type="password" placeholder="Enter Password" name="psw" required></asp:TextBox>
                    
                    <asp:Button ID="Button1" runat="server"   class="button_login" Text="Connexion" OnClick="Button1_Click" />
                   <asp:Label ID="Label"  runat="server" ></asp:Label>


                </div>
            </form>

        </div>
    </div>



    <!--Menu section-->


    <div class="footer__container">

        <section class="social__media">
            <div class="social__media--wrap">
                <div class="footer__logo">
                    <a href="/" id="footer__logo">Logo</a>
                </div>
                <p class="website__rights">&#169; UN PEU + 2021. All rights reserved</p>
                <div class="social__icons">
                    <a href="/" class="social__icon--link" target="_blank"><i class="fab fa-facebook"></i></a>
                    <a href="/" class="social__icon--link" target="_blank"><i class="fab fa-instagram"></i></a>
                    <a href="/" class="social__icon--link" target="_blank"><i class="fab fa-twitter"></i></a>
                </div>
            </div>
        </section>
    </div>
    <script src="app.js"></script>
</body>

</html>