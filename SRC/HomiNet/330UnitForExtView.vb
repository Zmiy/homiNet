Imports System.ComponentModel

Public Class Usc330GridCell

    Friend Sub AddColor(clr As Color)
        'Me.gbxProduct.BackColor = clr
        Me.pnlBackGround.BackColor = clr
        For Each cntrl As Control In Me.pnlBackGround.Controls
            cntrl.BackColor = clr
        Next
    End Sub

    Public Property ValueBefore As Integer

    Public Property CellProductName As String
        Get
            Return lblProductName.Text
        End Get
        Set(value As String)
            lblProductName.Text = value
        End Set
    End Property
    Public Property CellNumber As Integer
        Set(value As Integer)
            gbxProduct.Text = value.ToString()
        End Set
        Get
            Return CInt(gbxProduct.Text)
        End Get
    End Property


    Public ReadOnly Property ForManualRefillValue As String
        Get
            Dim val As Integer = CInt(numudCnt.Value) - ValueBefore
            If val < 0 Then
                val += 16
            End If
            Return val.ToString()
        End Get
    End Property

    Public Property RealValue As Integer
        Get
            Return CInt(numudCnt.Value)
        End Get
        Set(value As Integer)
            numudCnt.Value = value
        End Set
    End Property
    Public Property MaxGridValue As Integer
        Get
            Return CInt(lblMaxCnt.Text)
        End Get
        Set(value As Integer)
            If value = Integer.MaxValue Then
                lblMaxCnt.Text = 0.ToString()
                numudCnt.Minimum = -6
                numudCnt.Maximum = 6
            Else
                lblMaxCnt.Text = value.ToString()
                numudCnt.Minimum = value * -1
                numudCnt.Maximum = value
            End If

        End Set
    End Property

    Public Property NotUseImage As Bitmap
        Set(value As Bitmap)
            Me.gbxProduct.BackgroundImage = value
            For Each cntrl As Control In Me.gbxProduct.Controls
                cntrl.Visible = (value Is Nothing)
            Next
        End Set
        Get
            Return Me.gbxProduct.BackgroundImage
        End Get
    End Property

    Private Sub GetAllControls(ctrl As Control, ctrlList As List(Of Control))
        ctrlList.Add(ctrl)
        For Each cnt As Control In ctrl.Controls
            GetAllControls(cnt, ctrlList)
        Next
    End Sub
    Friend Sub Reset()
        Dim ctrlList As List(Of Control) = New List(Of Control)()
        GetAllControls(Me, ctrlList)
        ctrlList.ForEach(Function(x) x.Text = "")
        ValueBefore = 0
    End Sub
    Friend Sub RemoveImage()
        Me.gbxProduct.BackgroundImage = Nothing
        For Each cntrl As Control In Me.gbxProduct.Controls
            cntrl.Visible = True
        Next
    End Sub

    Friend Sub AddImage(img As Bitmap)

    End Sub

    Private Sub numudCnt_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles numudCnt.VisibleChanged

    End Sub
End Class
