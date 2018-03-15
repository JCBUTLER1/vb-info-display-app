'Project:	  Project 1 – My Information
'Description: Information form displays picture when Show Picture button is pressed. 
'             Displays address labels when Show Info button is pressed.
'             Radio button selection changes the font color of the label text.
'Programmer:  Jerrodo Butler
'Date:		  Spring 2018

Option Strict On
Public Class frmInfo
    Private Sub chkShowPic_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPic.CheckedChanged
        picInfoPic.Visible = chkShowPic.Checked 'When the chkShowPic checkbox is checked, the picture is visible, when it is unchecked the picture is not visible.
    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        lblName.Visible = True 'When the ShowInfo button is clicked, the Name, Street, and CityInfo labels are made visible.
        lblStreet.Visible = True
        lblCityInfo.Visible = True
    End Sub

    Private Sub radBlack_CheckedChanged(sender As Object, e As EventArgs) Handles radBlack.CheckedChanged
        lblName.ForeColor = Color.Black 'When the radBlack radio button is selected, the color of the Name, Street, and CityInfo label text are changed to black.
        lblStreet.ForeColor = Color.Black
        lblCityInfo.ForeColor = Color.Black
    End Sub

    Private Sub radRed_CheckedChanged(sender As Object, e As EventArgs) Handles radRed.CheckedChanged
        lblName.ForeColor = Color.Red 'When the radRed radio button is selected, the color of the Name, Street, and CityInfo label text are changed to red.
        lblStreet.ForeColor = Color.Red
        lblCityInfo.ForeColor = Color.Red
    End Sub

    Private Sub radBlue_CheckedChanged(sender As Object, e As EventArgs) Handles radBlue.CheckedChanged
        lblName.ForeColor = Color.Blue 'When the radBlue radio button is selected, the color of the Name, Street, and CityInfo label text are changed to blue.
        lblStreet.ForeColor = Color.Blue
        lblCityInfo.ForeColor = Color.Blue
    End Sub

    Private Sub radGreen_CheckedChanged(sender As Object, e As EventArgs) Handles radGreen.CheckedChanged
        lblName.ForeColor = Color.Green 'When the radGreen radio button is selected, the color of the Name, Street, and CityInfo label text are changed to green.
        lblStreet.ForeColor = Color.Green
        lblCityInfo.ForeColor = Color.Green
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close() 'When the Exit button is clicked, the form closes.
    End Sub
End Class
