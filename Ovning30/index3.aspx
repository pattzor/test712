<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index3.aspx.cs" Inherits="Ovning30.index3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/jquery-3.0.0.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <script>
        $(document).ready(function () {

            $("#myButton").click(function () {
                $.get("/svc/contact.aspx?action=getAllContacts")
                    .done(function (data) {
                        var myJSON = JSON.parse(data);

                        for (var i = 0; i < myJSON.length; i++) {
                            $("#tableBody").append("<tr><td>" + myJSON[i].ID + "</td><td>" + myJSON[i].Firstname + "</td></tr>");
                        }
                    });
            });
        });

        function AddContact() {

            var firstName = $("#firstName").val();

            $.get("/svc/contact.aspx?action=addContact&firstName" + firstName)
                .done(function (data) {
                    alert(data);
                });
        }
    </script>

    <table class="table table-bordered table-hover">
        <thead>
            <tr>
                <th>ID</th>
                <th>Firstname</th>
            </tr>
        </thead>
        <tbody id="tableBody"></tbody>
    </table>

    <input type="button" id="myButton" value="Click me, click me!" />

     <table class="table table-bordered table-hover">
        <thead>
            <tr>
                <th>Firstname</th>
                <th>Lastname</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><input type="text" id="firstName" /></td>
                <td><input type="text" id="lastName" /></td>
            </tr>
        </tbody>
    </table>

    <input type="button" onclick="AddContact();" value="Add contact" />
</asp:Content>