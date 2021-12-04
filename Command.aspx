<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Command.aspx.cs" Inherits="BiB.Command" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Un Peu+</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" integrity="sha512-+4zCK9k+qNFUR5X+cKL9EIR+ZOhtIloNl9GIKS57V1MyNsYpYcUrUeQc9vNfzsWfV28IaLL3i96P9sdNyeRssA==" crossorigin="anonymous" />
    <link href="Style/layout.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet">

</head>

<body>

    <!--Navbar-->

    <nav class="navbar">
        <div class="navbar__container">
            <a href="index.html" id="navbar__logo">UN PEU PLUS +</a>
            <div class="navbar__toggle" id="mobile-menu">
                <span class="bar"></span>
                <span class="bar"></span>
                <span class="bar"></span>
            </div>
              <ul class="navbar__menu">
                <li class="navbar__item">
                    <a href="Admin.aspx" class="navbar__links" id="home-page">Admin &nbsp;<i class="fa fa-user"></i></a>
                </li>
                <li class="navbar__item">
                    <a href="Livres.aspx" class="navbar__links">Livres &nbsp;<i class="fa fa-book"></i> </a>
                </li>
                <li class="navbar__item">
                    <a href="Command.aspx" class="navbar__links "> Commandes&nbsp;<i class="fa fa-shopping-cart"></i></a>
                </li>
                <li class="navbar__item">
                    <a href="Clients.aspx" class="navbar__links">Clients <i class="fa fa-client"></i></a>
                </li>
                <li class="navbar__btn">
                    <a href="WebForm4.aspx" class="button_login">Acceuil&nbsp;<i class="fa fa-home"></i> </a>
                </li>
            </ul>
        </div>
    </nav>
    <!--
Include Tailwind JIT CDN compiler
More info: https://beyondco.de/blog/tailwind-jit-compiler-via-cdn
-->
    <script src="https://unpkg.com/tailwindcss-jit-cdn"></script>

    <!-- Snippet -->

    <!-- Table -->
    <form runat="server">

                            <asp:GridView ID="GridView1" runat="server" >
                            </asp:GridView>
               

                        </form>







    <footer class="container">
    </footer>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js"></script>
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