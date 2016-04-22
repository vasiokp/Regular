Public Class HelpForm


    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datahelp.Rows.Add("1", " (a-zA-Z)")
        datahelp.Rows.Add("2", " (a-zA-Z)")
        datahelp.Rows.Add("3", " (a-z)")
        datahelp.Rows.Add("4", " (a-zA-Z)")
        datahelp.Rows.Add("5", " (a-zA-Z)(+-*/)")
        datahelp.Rows.Add("6", " (a-zA-Z)")
        datahelp.Rows.Add("7", " (a-zA-Z)")
        datahelp.Rows.Add("8", " (a-z)")
        datahelp.Rows.Add("9", " (a-zA-Z0-9.,:;)")
        datahelp.Rows.Add("10", " (0-9)")
        datahelp.Rows.Add("11", " (a-yA-Y) - голосна")
        datahelp.Rows.Add("12", " (a-zA-Z)")
        datahelp.Rows.Add("13", " (a-zA-Z)")
        datahelp.Rows.Add("14", " (a-zA-Z0-9~!*@$#^&%-,:)")
        datahelp.Rows.Add("15", " (a-zA-Z;)")
        datahelp.Rows.Add("16", " (a-zA-Z;)")
        datahelp.Rows.Add("17", " (+-*/)")
        datahelp.Rows.Add("18", " (kpsfth")
        datahelp.Rows.Add("19", " (bvgdzlmnr")
        datahelp.Rows.Add("20", " (A-Z)")
        datahelp.Rows.Add("21", " (0-9)")
        datahelp.Rows.Add("22", " (.,:;)")
        datahelp.Rows.Add("23", " (a-yA-Y) - голосна")
        datahelp.Rows.Add("24", " (a-zA-Z)")
        datahelp.Rows.Add("25", " (+-*/)")
        datahelp.Rows.Add("26", " (b-zB-Z) - приголосна")
        datahelp.Rows.Add("27", " (a-zA-Z)")
        datahelp.Rows.Add("28", " (~!*@$#^&%-,:)")
        datahelp.Rows.Add("29", " (+-*/)")
        datahelp.Rows.Add("30", " (a-zA-Z)")

    End Sub

    Private Sub datahelp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datahelp.CellContentClick

    End Sub
End Class