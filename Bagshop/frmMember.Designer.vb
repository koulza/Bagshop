﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMember
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvMember = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAdd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(601, 554)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลลูกค้า"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(232, 456)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTel.MaxLength = 10
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(220, 30)
        Me.txtTel.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "เบอร์โทร"
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(232, 259)
        Me.txtAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdd.MaxLength = 150
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(220, 173)
        Me.txtAdd.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ที่อยู่"
        '
        'txtNa
        '
        Me.txtNa.Location = New System.Drawing.Point(232, 187)
        Me.txtNa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNa.MaxLength = 50
        Me.txtNa.Name = "txtNa"
        Me.txtNa.Size = New System.Drawing.Size(220, 30)
        Me.txtNa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ชื่อลูกค้า"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(232, 101)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtID.MaxLength = 4
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(220, 30)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสลูกค้า"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(547, 609)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(73, 44)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(450, 609)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(91, 44)
        Me.btncancel.TabIndex = 29
        Me.btncancel.Text = "ยกเลิก"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(256, 609)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 44)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(165, 609)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(73, 44)
        Me.btnEdit.TabIndex = 26
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(359, 609)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 44)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(72, 609)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(73, 44)
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvMember
        '
        Me.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMember.Location = New System.Drawing.Point(22, 689)
        Me.dgvMember.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvMember.Name = "dgvMember"
        Me.dgvMember.Size = New System.Drawing.Size(626, 227)
        Me.dgvMember.TabIndex = 31
        '
        'frmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 956)
        Me.Controls.Add(Me.dgvMember)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Ekkamai Standard", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "frmMember"
        Me.Text = "ข้อมูลลูกค้า "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dgvMember As System.Windows.Forms.DataGridView
End Class
