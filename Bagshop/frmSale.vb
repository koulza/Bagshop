﻿Imports System.Data
Imports System.Data.SqlClient
Public Class frmSale
    Public j, h, amount As Integer
    Dim sum As Double
    Dim row As Integer
    Dim save_status As String
    Dim x As String
    Private Sub frmSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet

        Module1.Connect()
        sql = "SELECT U_USer, U_Name From Userr"
        'sql = "SELECT U_ID,U_User,U_Name FROM Userr  where U_User  = '" & User_Na & "'"

        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Userr")
        If ds.Tables("Userr").Rows.Count <> 0 Then
            cmbUser.DataSource = ds.Tables("Userr")
            cmbUser.ValueMember = "U_User"
            cmbUser.DisplayMember = "U_Name"
        End If
        sql = "SELECT p.P_ID,p.P_Name,pr.Pr_Color,pr.Pr_Amount,p.P_Price,pr.Pr_Num FROM Product p , Property pr where p.P_ID = pr.P_ID order by P_ID"
        da = New SqlDataAdapter(sql, Conn)
        da.Fill(ds, "Product")
        dgvProduct.ReadOnly = True
        dgvProduct.DataSource = ds.Tables("Product")
        dgvProduct.Columns(0).HeaderText = "รหัสสินค้า"
        dgvProduct.Columns(0).Width = 100
        dgvProduct.Columns(1).HeaderText = "ชื่อสินค้า"
        dgvProduct.Columns(1).Width = 100
        dgvProduct.Columns(4).HeaderText = "ราคา"
        dgvProduct.Columns(4).Width = 100
        dgvProduct.Columns(3).HeaderText = "จำนวนคงเหลือ"
        dgvProduct.Columns(3).Width = 100
        dgvProduct.Columns(2).HeaderText = "สี"
        dgvProduct.Columns(2).Width = 100
        dgvProduct.Columns(5).Visible = False
        cmbUser.Enabled = False
        dtsale.Enabled = False
        txtMID.Enabled = False
        txtMNa.Enabled = False
        btnSearch.Enabled = False
        txtColor.Enabled = False
        txtPID.Enabled = False
        txtPNa.Enabled = False
        txtPrice.Enabled = False
        txtAmount.Enabled = False
        txtsale.Enabled = False
        btAdd.Enabled = False
        btRemove.Enabled = False
        dtsale.Enabled = False
        dgvProduct.Enabled = False
        dgvSale.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = False
        dtsale.Enabled = False
    End Sub

    Sub clear()
        txtPID.Text = ""
        txtPNa.Text = ""
        txtsale.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Dim Gid, Gname, GColor As String
        Dim Gnum, Gamount, aaa As Integer
        Dim Gprice, Gtotal As Double
        '**********************************************************************
        If txtsale.Text = "" Then
            MessageBox.Show("กรุณาใส่จำนวนที่สั่งซื้อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If CInt(txtsale.Text) = 0 Then
            MessageBox.Show("กรุณาใส่จำนวนที่สั่งซื้อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If CInt(amount) < CInt(txtsale.Text) Then
            MessageBox.Show("จำนวนที่ซื้อมากกว่าจำนวนคงเหลือ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtMID.Text = "" Then
            MessageBox.Show("กรุณาเลือกลูกค้า", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Gamount = CInt(txtAmount.Text)
        Gid = txtPID.Text
        Gname = txtPNa.Text
        Gprice = CDbl(txtPrice.Text)
        Gnum = CInt(txtsale.Text)
        GColor = txtColor.Text

        aaa = (txtnum.Text)

        h = Gamount - Gnum
        Gtotal = Gnum * Gprice
        Dim Color As String = txtColor.Text
        sum = sum + Gtotal
        If dgvSale.RowCount - 2 >= 0 Then
            Dim a, x As Integer
            For a = 0 To dgvSale.RowCount - 2
                If dgvSale.Rows(a).Cells(2).Value = dgvProduct.Rows(row).Cells(2).Value And dgvSale.Rows(a).Cells(0).Value = dgvProduct.Rows(row).Cells(0).Value Then
                    x = a
                End If
            Next
            If dgvSale.Rows(x).Cells(2).Value = dgvProduct.Rows(row).Cells(2).Value And dgvSale.Rows(x).Cells(0).Value = dgvProduct.Rows(row).Cells(0).Value Then
                dgvSale.Rows(x).Cells(4).Value = CInt(dgvSale.Rows(x).Cells(4).Value) + CInt(txtsale.Text)
                dgvSale.Rows(x).Cells(5).Value = CInt(dgvSale.Rows(x).Cells(5).Value) + CInt(txtsale.Text) * CInt(txtPrice.Text)
                dgvProduct.Rows(row).Cells(3).Value = CInt(txtAmount.Text) - CInt(txtsale.Text)
                dgvSale.Rows(x).Cells(2).Value = dgvProduct.Rows(row).Cells(2).Value
                sum = 0
                For i As Integer = 0 To dgvSale.RowCount - 2
                    sum += CInt(dgvSale.Rows(i).Cells(5).Value)
                Next
                lblSum.Text = sum.ToString("#,##.00")
                clear()
                dgvProduct.Rows(row).Cells(3).Value = Gamount - Gnum
                btnSave.Enabled = True
                Exit Sub
            End If
        End If

        dgvSale.Rows.Add(Gid, Gname, Color, Gprice, Gnum, Gtotal, aaa)
        sum = 0
        For i As Integer = 0 To dgvSale.RowCount - 2
            sum += CInt(dgvSale.Rows(i).Cells(5).Value)
        Next
        lblSum.Text = sum.ToString("#,##.00")
        clear()
        dgvProduct.Rows(row).Cells(3).Value = Gamount - Gnum
        btnSave.Enabled = True

        '************************************************************************************************
        clear()
        txtPID.Text = ""
        txtPNa.Text = ""
        txtAmount.Text = ""
        txtPrice.Text = ""
        txtsale.Text = ""
        txtPID.Enabled = False
        txtPNa.Enabled = False
        cmbUser.Enabled = True
        txtAmount.Enabled = False
        txtPrice.Enabled = False
        txtsale.Enabled = False
        dgvProduct.Enabled = True
        dgvSale.Enabled = True
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btncancel.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = False
        If dgvSale.Rows.Count > 1 Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
        btAdd.Enabled = True
        btRemove.Enabled = False
    End Sub



    Private Sub btRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRemove.Click
        'If dgvSale.Rows.Count <= 1 Then Exit Sub
        'sum = sum - Val(dgvSale.CurrentRow.Cells(5).Value)
        'lblSum.Text = sum.ToString("#,##.00")
        'dgvSale.Rows.Remove(dgvSale.CurrentRow)
        ' If dgvSale.Rows.Count <= 1 Then
        'btRemove.Enabled = False
        ' btnSave.Enabled = False
        ' End If
        Dim X As Integer = 0
        While dgvProduct.Rows(X).Cells(5).Value <> dgvSale.Rows(row).Cells(6).Value
            'MessageBox.Show(X)
            X += 1
        End While
        'For a = 0 To dgvProduct.RowCount
        'If dgvSale.Rows(a).Cells(0).Value <> dgvProduct.Rows(row).Cells(0).Value Then
        'X = a
        'MessageBox.Show(a)
        'MessageBox.Show(X)
        'End If
        'Next
        'MessageBox.Show(X)
        dgvProduct.Rows(X).Cells(3).Value = CInt(dgvProduct.Rows(X).Cells(3).Value) + CInt(dgvSale.Rows(row).Cells(4).Value)
        If dgvSale.RowCount = 2 Then
            sum = 0
            lblSum.Text = "0.00"
            dgvSale.Rows.Remove(dgvSale.CurrentRow)
        Else
            sum -= CInt(dgvSale.Rows(row).Cells(5).Value)
            dgvSale.Rows.Remove(dgvSale.CurrentRow)
            lblSum.Text = sum.ToString("#,##.00")
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Sql As String
        Dim key_Gen As String = ""
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand

        Module1.Connect()
        Sql = "SELECT MAX(O_ID)From Orderr"
        sqlCmd = New SqlCommand(Sql, Conn)                          'สร้าง sqlCmd โดยให้เก็บคำสั้่งที่อยู่ใน sql 
        sqlDr = sqlCmd.ExecuteReader                                'ประมวลผลคำสั้ง และ นำผลลัพธ์เก็บไว้ใน sqlDr
        If sqlDr.Read() Then                                        'ตรวจสอบว่าอ่านข้อมูลได้ จะเข้าไปทำในเงื่อนไข
            If sqlDr.IsDBNull(0) Then    'ตรวจสอบว่าได้ค่าว่าง จะเข้าไปทำ
                key_Gen = "O001"                                    'กำหนดให้ key_Gen เริ่มที่E001
            Else                                                    'ในกรณีที่อ่านแล้วได้ข้อมูล จะมาทำตรงนี้
                key_Gen = sqlDr.Item(0)                             'กำหนดให้key_Genเม่ากับค่าที่อ่นขึ้นมาได้ เช่น E001                           
                key_Gen = Trim(key_Gen)                             'ตัดช่องว่างในkey_Gen ทั้งหมด
                key_Gen = Strings.Right(key_Gen, 3)                 'ตัดข้อมูลจากทางขวามา3 หลัก จะได้ 001
                key_Gen = CInt(key_Gen) + 1                         'นำข้อมูลมาแปลเป็น int แล้วบวกเพิ่มอีก1 จะได้2
                key_Gen = Strings.Right(("00" & key_Gen), 3)        'นำข้อมูลที่บวกแล้วมาเติม0ด้านหน้าให้ครบ3 
                key_Gen = "O" & key_Gen                             'นำข้อมูลเติม 0 แล้วมาใว่ E ด้านหน้า จะกลายเป็น E002
            End If
        End If
        sqlDr.Close()       'ใช่เสร็จแล้วต้องปิด   
        sum = 0
        txtID.Text = key_Gen
        txtColor.Enabled = False
        cmbUser.Enabled = True
        dtsale.Enabled = False
        txtMID.Enabled = False
        btnSearch.Enabled = True
        txtMNa.Enabled = False
        txtPID.Enabled = False
        txtPNa.Enabled = False
        txtPrice.Enabled = False
        txtAmount.Enabled = False
        txtsale.Enabled = False
        btAdd.Enabled = True
        btRemove.Enabled = True
        dgvProduct.Enabled = True
        dgvSale.Enabled = False
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btncancel.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = False
        'save_status = "Add"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim sqlCmd As SqlCommand
        Dim sqlDr As SqlDataReader
        Dim M_ID, saleID, Num, Price, ID, orderDate, Total, Color As String
        Dim i, k, orderID As Integer
        k = dgvSale.RowCount - 2
        If k < 0 Then
            MessageBox.Show("กรุณาทำรายการสั่งซื้อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        orderDate = Today.Date.ToString("s")
        sql = "insert into Orderr (O_ID,O_Date,Net,M_ID,U_User,Pr_Color)"
        sql &= "values('" & CStr(txtID.Text) & "','" & orderDate & "','" & CDbl(lblSum.Text) & "','" & CStr(txtMID.Text) & "','" & cmbUser.SelectedValue & "','" & txtColor.Text & "')"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlCmd.ExecuteNonQuery()
        sql = "select Max(O_ID)from Orderr"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        sqlDr.Read()
        'saleID = txtID.Text
        saleID = sqlDr.Item(0)
        sqlDr.Close()
        For i = 0 To k
            ID = dgvSale.Rows(i).Cells(0).Value
            Num = dgvSale.Rows(i).Cells(4).Value
            Price = dgvSale.Rows(i).Cells(3).Value
            Total = dgvSale.Rows(i).Cells(5).Value
            Color = dgvSale.Rows(i).Cells(2).Value
            sql = "insert into Order_Product (O_ID,P_ID,Num,Price,Total,Pr_Color)"
            sql &= "values ('" & saleID & "','" & ID & "','" & Num & "','" & Price & "','" & Total & "','" & Color & "')"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
        Next
        k = dgvProduct.RowCount - 2
        For i = 0 To k
            sql = "update Property set Pr_Amount = '" & dgvProduct.Rows(i).Cells(3).Value & "' where Pr_Num = '" & dgvProduct.Rows(i).Cells(5).Value & "'"
            sqlCmd = New SqlCommand(sql, Conn)
            sqlCmd.ExecuteNonQuery()
        Next
        MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "ยืนยันการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtID.Text = saleID
        txtPID.Enabled = False
        txtPNa.Enabled = False
        cmbUser.Enabled = False
        txtAmount.Enabled = False
        txtPrice.Enabled = False
        txtsale.Enabled = False
        dgvProduct.Enabled = False
        dgvSale.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btncancel.Enabled = True
        btnExit.Enabled = True
        btnPrint.Enabled = True
        btAdd.Enabled = False
        btRemove.Enabled = False
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Sql = "SELECT p.P_ID,p.P_Name,pr.Pr_Color,pr.Pr_Amount,p.P_Price,pr.Pr_Num FROM Product p , Property pr where p.P_ID = pr.P_ID order by P_ID"
        da = New SqlDataAdapter(Sql, Conn)
        da.Fill(ds, "Product")
        dgvProduct.ReadOnly = True
        dgvProduct.DataSource = ds.Tables("Product")
        dgvProduct.Columns(0).HeaderText = "รหัสสินค้า"
        dgvProduct.Columns(0).Width = 100
        dgvProduct.Columns(1).HeaderText = "ชื่อสินค้า"
        dgvProduct.Columns(1).Width = 100
        dgvProduct.Columns(4).HeaderText = "ราคา"
        dgvProduct.Columns(4).Width = 100
        dgvProduct.Columns(3).HeaderText = "จำนวนคงเหลือ"
        dgvProduct.Columns(3).Width = 100
        dgvProduct.Columns(2).HeaderText = "สี"
        dgvProduct.Columns(2).Width = 100
        dgvProduct.Columns(5).Visible = False
        txtPID.Text = ""
        txtPNa.Text = ""
        txtAmount.Text = ""
        txtPrice.Text = ""
        txtsale.Text = ""
        txtColor.Text = ""
        lblSum.Text = "0.00"
        txtPID.Enabled = False
        txtPNa.Enabled = False
        cmbUser.Enabled = False
        txtAmount.Enabled = False
        txtPrice.Enabled = False
        txtsale.Enabled = False
        dgvProduct.Enabled = False
        dgvSale.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btncancel.Enabled = False
        btnExit.Enabled = True
        btnPrint.Enabled = False
        btAdd.Enabled = False
        btRemove.Enabled = False
        dtsale.Enabled = False
        txtID.Text = ""
        txtMID.Text = ""
        txtMNa.Text = ""
        dgvSale.Rows.Clear()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If txtID.Text = "" Then
            MessageBox.Show("กรูณาทำรายการก่อน", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        frmSlipSale.Show()
        clear()
        dgvSale.Rows.Clear()
        txtPID.Text = ""
        txtPNa.Text = ""
        txtAmount.Text = ""
        txtPrice.Text = ""
        txtsale.Text = ""
        txtPID.Enabled = False
        txtPNa.Enabled = False
        cmbUser.Enabled = False
        txtAmount.Enabled = False
        txtPrice.Enabled = False
        txtsale.Enabled = False
        dgvProduct.Enabled = False
        dgvSale.Enabled = False
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btncancel.Enabled = False
        btnExit.Enabled = True
        btnPrint.Enabled = False
        btAdd.Enabled = False
        btRemove.Enabled = False
        dtsale.Enabled = False
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmMerber1.Show()
    End Sub

    Private Sub dgvProduct_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick

    End Sub

    Private Sub dgvProduct_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellContentDoubleClick
        Dim sql As String
        Dim sqlDr As SqlDataReader
        Dim sqlCmd As SqlCommand
        row = e.RowIndex
        txtPID.Text = dgvProduct.Rows(e.RowIndex).Cells(0).Value
        txtPNa.Text = dgvProduct.Rows(e.RowIndex).Cells(1).Value
        txtPrice.Text = dgvProduct.Rows(e.RowIndex).Cells(4).Value
        txtAmount.Text = dgvProduct.Rows(e.RowIndex).Cells(3).Value
        txtColor.Text = dgvProduct.Rows(e.RowIndex).Cells(2).Value
        txtnum.Text = dgvProduct.Rows(e.RowIndex).Cells(5).Value
        amount = dgvProduct.Rows(e.RowIndex).Cells(3).Value
        'x = dgvProduct.Rows(e.RowIndex).Cells(5).Value
        sql = "Select P_Price FROM Product WHERE P_ID = '" & txtPID.Text & "'"
        sqlCmd = New SqlCommand(sql, Conn)
        sqlDr = sqlCmd.ExecuteReader
        If sqlDr.Read() Then
            txtPrice.Text = sqlDr.Item(0)
        End If
        sqlDr.Close()
        txtsale.Enabled = True
    End Sub

    Private Sub txtsale_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsale.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13,
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณาระบุข้อมูลเป็นตัวเลข")
        End Select
    End Sub

    Private Sub dgvSale_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSale.CellContentClick

    End Sub

    Private Sub dgvSale_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSale.CellContentDoubleClick
        row = e.RowIndex
        btRemove.Enabled = True
        btRemove.BackColor = Color.FromArgb(52, 172, 224)
    End Sub

    Private Sub frmSale_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("คุณต้องการออกจากโปรแกรมหรือไม่?", "Exit Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub cmbUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUser.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class