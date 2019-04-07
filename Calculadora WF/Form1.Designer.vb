<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalc
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNumeros = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.BtnEqual = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDiv = New System.Windows.Forms.Button()
        Me.BtnMult = New System.Windows.Forms.Button()
        Me.BtnMinus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumeros
        '
        Me.lblNumeros.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeros.Location = New System.Drawing.Point(4, 74)
        Me.lblNumeros.Name = "lblNumeros"
        Me.lblNumeros.Size = New System.Drawing.Size(225, 23)
        Me.lblNumeros.TabIndex = 0
        Me.lblNumeros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.lblOperacion)
        Me.Panel1.Controls.Add(Me.lblNumeros)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 100)
        Me.Panel1.TabIndex = 1
        '
        'lblOperacion
        '
        Me.lblOperacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacion.Location = New System.Drawing.Point(5, 5)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(225, 23)
        Me.lblOperacion.TabIndex = 1
        Me.lblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(26, 160)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(41, 41)
        Me.Btn1.TabIndex = 2
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(73, 160)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(41, 41)
        Me.Btn2.TabIndex = 3
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(120, 160)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(41, 41)
        Me.Btn3.TabIndex = 4
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Location = New System.Drawing.Point(120, 113)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(41, 41)
        Me.Btn6.TabIndex = 7
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Location = New System.Drawing.Point(73, 113)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(41, 41)
        Me.Btn5.TabIndex = 6
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(26, 113)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(41, 41)
        Me.Btn4.TabIndex = 5
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Location = New System.Drawing.Point(120, 66)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(41, 41)
        Me.Btn9.TabIndex = 10
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Location = New System.Drawing.Point(73, 66)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(41, 41)
        Me.Btn8.TabIndex = 9
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.Location = New System.Drawing.Point(26, 66)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(41, 41)
        Me.Btn7.TabIndex = 8
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(26, 207)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(88, 41)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "0"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(120, 207)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(41, 41)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "."
        Me.Button10.UseVisualStyleBackColor = True
        '
        'BtnEqual
        '
        Me.BtnEqual.Location = New System.Drawing.Point(167, 160)
        Me.BtnEqual.Name = "BtnEqual"
        Me.BtnEqual.Size = New System.Drawing.Size(41, 88)
        Me.BtnEqual.TabIndex = 13
        Me.BtnEqual.Text = "="
        Me.BtnEqual.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(167, 66)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(41, 88)
        Me.BtnAdd.TabIndex = 14
        Me.BtnAdd.Text = "+"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnDiv
        '
        Me.BtnDiv.Location = New System.Drawing.Point(26, 19)
        Me.BtnDiv.Name = "BtnDiv"
        Me.BtnDiv.Size = New System.Drawing.Size(41, 41)
        Me.BtnDiv.TabIndex = 15
        Me.BtnDiv.Text = "/"
        Me.BtnDiv.UseVisualStyleBackColor = True
        '
        'BtnMult
        '
        Me.BtnMult.Location = New System.Drawing.Point(73, 19)
        Me.BtnMult.Name = "BtnMult"
        Me.BtnMult.Size = New System.Drawing.Size(41, 41)
        Me.BtnMult.TabIndex = 16
        Me.BtnMult.Text = "*"
        Me.BtnMult.UseVisualStyleBackColor = True
        '
        'BtnMinus
        '
        Me.BtnMinus.Location = New System.Drawing.Point(120, 19)
        Me.BtnMinus.Name = "BtnMinus"
        Me.BtnMinus.Size = New System.Drawing.Size(88, 41)
        Me.BtnMinus.TabIndex = 17
        Me.BtnMinus.Text = "-"
        Me.BtnMinus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnMinus)
        Me.GroupBox1.Controls.Add(Me.Btn1)
        Me.GroupBox1.Controls.Add(Me.BtnMult)
        Me.GroupBox1.Controls.Add(Me.Btn2)
        Me.GroupBox1.Controls.Add(Me.BtnDiv)
        Me.GroupBox1.Controls.Add(Me.Btn3)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.Btn4)
        Me.GroupBox1.Controls.Add(Me.BtnEqual)
        Me.GroupBox1.Controls.Add(Me.Btn5)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Btn6)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Btn7)
        Me.GroupBox1.Controls.Add(Me.Btn9)
        Me.GroupBox1.Controls.Add(Me.Btn8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 257)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'FrmCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 387)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCalc"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNumeros As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblOperacion As Label
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents BtnEqual As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDiv As Button
    Friend WithEvents BtnMult As Button
    Friend WithEvents BtnMinus As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
