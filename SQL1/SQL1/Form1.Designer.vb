<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnOpenSQL = New System.Windows.Forms.Button()
        Me.btnGetSQlInfo = New System.Windows.Forms.Button()
        Me.btnCloseSQL = New System.Windows.Forms.Button()
        Me.btnOpenOLEDB = New System.Windows.Forms.Button()
        Me.btnGetOLEDBInfo = New System.Windows.Forms.Button()
        Me.btnCloseOLEDB = New System.Windows.Forms.Button()
        Me.lblSQLConnectionSatte = New System.Windows.Forms.Label()
        Me.lblOLEDBConnectionState = New System.Windows.Forms.Label()
        Me.BtnConnToInvalidDatabase = New System.Windows.Forms.Button()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenSQL
        '
        Me.btnOpenSQL.Location = New System.Drawing.Point(32, 94)
        Me.btnOpenSQL.Name = "btnOpenSQL"
        Me.btnOpenSQL.Size = New System.Drawing.Size(157, 67)
        Me.btnOpenSQL.TabIndex = 0
        Me.btnOpenSQL.Text = "Open SQL"
        Me.btnOpenSQL.UseVisualStyleBackColor = True
        '
        'btnGetSQlInfo
        '
        Me.btnGetSQlInfo.Location = New System.Drawing.Point(329, 94)
        Me.btnGetSQlInfo.Name = "btnGetSQlInfo"
        Me.btnGetSQlInfo.Size = New System.Drawing.Size(157, 67)
        Me.btnGetSQlInfo.TabIndex = 1
        Me.btnGetSQlInfo.Text = "GET SQL Info"
        Me.btnGetSQlInfo.UseVisualStyleBackColor = True
        '
        'btnCloseSQL
        '
        Me.btnCloseSQL.Location = New System.Drawing.Point(569, 94)
        Me.btnCloseSQL.Name = "btnCloseSQL"
        Me.btnCloseSQL.Size = New System.Drawing.Size(157, 67)
        Me.btnCloseSQL.TabIndex = 2
        Me.btnCloseSQL.Text = "Close SQL"
        Me.btnCloseSQL.UseVisualStyleBackColor = True
        '
        'btnOpenOLEDB
        '
        Me.btnOpenOLEDB.Location = New System.Drawing.Point(32, 248)
        Me.btnOpenOLEDB.Name = "btnOpenOLEDB"
        Me.btnOpenOLEDB.Size = New System.Drawing.Size(157, 67)
        Me.btnOpenOLEDB.TabIndex = 3
        Me.btnOpenOLEDB.Text = "Open OLEDB"
        Me.btnOpenOLEDB.UseVisualStyleBackColor = True
        '
        'btnGetOLEDBInfo
        '
        Me.btnGetOLEDBInfo.Location = New System.Drawing.Point(329, 248)
        Me.btnGetOLEDBInfo.Name = "btnGetOLEDBInfo"
        Me.btnGetOLEDBInfo.Size = New System.Drawing.Size(157, 67)
        Me.btnGetOLEDBInfo.TabIndex = 4
        Me.btnGetOLEDBInfo.Text = "Get OLEDB Info"
        Me.btnGetOLEDBInfo.UseVisualStyleBackColor = True
        '
        'btnCloseOLEDB
        '
        Me.btnCloseOLEDB.Location = New System.Drawing.Point(569, 248)
        Me.btnCloseOLEDB.Name = "btnCloseOLEDB"
        Me.btnCloseOLEDB.Size = New System.Drawing.Size(157, 67)
        Me.btnCloseOLEDB.TabIndex = 5
        Me.btnCloseOLEDB.Text = "Close OLEDB"
        Me.btnCloseOLEDB.UseVisualStyleBackColor = True
        '
        'lblSQLConnectionSatte
        '
        Me.lblSQLConnectionSatte.AutoSize = True
        Me.lblSQLConnectionSatte.Location = New System.Drawing.Point(234, 110)
        Me.lblSQLConnectionSatte.Name = "lblSQLConnectionSatte"
        Me.lblSQLConnectionSatte.Size = New System.Drawing.Size(51, 17)
        Me.lblSQLConnectionSatte.TabIndex = 6
        Me.lblSQLConnectionSatte.Text = "Label1"
        '
        'lblOLEDBConnectionState
        '
        Me.lblOLEDBConnectionState.AutoSize = True
        Me.lblOLEDBConnectionState.Location = New System.Drawing.Point(234, 273)
        Me.lblOLEDBConnectionState.Name = "lblOLEDBConnectionState"
        Me.lblOLEDBConnectionState.Size = New System.Drawing.Size(51, 17)
        Me.lblOLEDBConnectionState.TabIndex = 7
        Me.lblOLEDBConnectionState.Text = "Label2"
        '
        'BtnConnToInvalidDatabase
        '
        Me.BtnConnToInvalidDatabase.Location = New System.Drawing.Point(32, 360)
        Me.BtnConnToInvalidDatabase.Name = "BtnConnToInvalidDatabase"
        Me.BtnConnToInvalidDatabase.Size = New System.Drawing.Size(220, 78)
        Me.BtnConnToInvalidDatabase.TabIndex = 8
        Me.BtnConnToInvalidDatabase.Text = "Connect to Invalid Database"
        Me.BtnConnToInvalidDatabase.UseVisualStyleBackColor = True
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(329, 371)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(157, 67)
        Me.btnEncrypt.TabIndex = 9
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(580, 371)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(157, 67)
        Me.btnDecrypt.TabIndex = 10
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.BtnConnToInvalidDatabase)
        Me.Controls.Add(Me.lblOLEDBConnectionState)
        Me.Controls.Add(Me.lblSQLConnectionSatte)
        Me.Controls.Add(Me.btnCloseOLEDB)
        Me.Controls.Add(Me.btnGetOLEDBInfo)
        Me.Controls.Add(Me.btnOpenOLEDB)
        Me.Controls.Add(Me.btnCloseSQL)
        Me.Controls.Add(Me.btnGetSQlInfo)
        Me.Controls.Add(Me.btnOpenSQL)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenSQL As Button
    Friend WithEvents btnGetSQlInfo As Button
    Friend WithEvents btnCloseSQL As Button
    Friend WithEvents btnOpenOLEDB As Button
    Friend WithEvents btnGetOLEDBInfo As Button
    Friend WithEvents btnCloseOLEDB As Button
    Friend WithEvents lblSQLConnectionSatte As Label
    Friend WithEvents lblOLEDBConnectionState As Label
    Friend WithEvents BtnConnToInvalidDatabase As Button
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents btnDecrypt As Button
End Class
