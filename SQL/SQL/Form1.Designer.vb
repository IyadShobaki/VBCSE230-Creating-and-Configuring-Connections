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
        Me.btnGetSQLInfo = New System.Windows.Forms.Button()
        Me.btnCloseSQL = New System.Windows.Forms.Button()
        Me.btnOpenOleDB = New System.Windows.Forms.Button()
        Me.btnGetOLEDBInfo = New System.Windows.Forms.Button()
        Me.btnCloseOLEDB = New System.Windows.Forms.Button()
        Me.lblSQLConnectionState = New System.Windows.Forms.Label()
        Me.lblOLEDBConnectionState = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOpenSQL
        '
        Me.btnOpenSQL.Location = New System.Drawing.Point(57, 45)
        Me.btnOpenSQL.Name = "btnOpenSQL"
        Me.btnOpenSQL.Size = New System.Drawing.Size(137, 47)
        Me.btnOpenSQL.TabIndex = 0
        Me.btnOpenSQL.Text = "Open SQL"
        Me.btnOpenSQL.UseVisualStyleBackColor = True
        '
        'btnGetSQLInfo
        '
        Me.btnGetSQLInfo.Location = New System.Drawing.Point(332, 45)
        Me.btnGetSQLInfo.Name = "btnGetSQLInfo"
        Me.btnGetSQLInfo.Size = New System.Drawing.Size(137, 47)
        Me.btnGetSQLInfo.TabIndex = 1
        Me.btnGetSQLInfo.Text = "Get SQL Info"
        Me.btnGetSQLInfo.UseVisualStyleBackColor = True
        '
        'btnCloseSQL
        '
        Me.btnCloseSQL.Location = New System.Drawing.Point(556, 45)
        Me.btnCloseSQL.Name = "btnCloseSQL"
        Me.btnCloseSQL.Size = New System.Drawing.Size(137, 47)
        Me.btnCloseSQL.TabIndex = 2
        Me.btnCloseSQL.Text = "Close SQL"
        Me.btnCloseSQL.UseVisualStyleBackColor = True
        '
        'btnOpenOleDB
        '
        Me.btnOpenOleDB.Location = New System.Drawing.Point(57, 226)
        Me.btnOpenOleDB.Name = "btnOpenOleDB"
        Me.btnOpenOleDB.Size = New System.Drawing.Size(137, 47)
        Me.btnOpenOleDB.TabIndex = 3
        Me.btnOpenOleDB.Text = "Open OleDB"
        Me.btnOpenOleDB.UseVisualStyleBackColor = True
        '
        'btnGetOLEDBInfo
        '
        Me.btnGetOLEDBInfo.Location = New System.Drawing.Point(332, 226)
        Me.btnGetOLEDBInfo.Name = "btnGetOLEDBInfo"
        Me.btnGetOLEDBInfo.Size = New System.Drawing.Size(137, 47)
        Me.btnGetOLEDBInfo.TabIndex = 4
        Me.btnGetOLEDBInfo.Text = "Get OLEDB Info"
        Me.btnGetOLEDBInfo.UseVisualStyleBackColor = True
        '
        'btnCloseOLEDB
        '
        Me.btnCloseOLEDB.Location = New System.Drawing.Point(556, 226)
        Me.btnCloseOLEDB.Name = "btnCloseOLEDB"
        Me.btnCloseOLEDB.Size = New System.Drawing.Size(137, 47)
        Me.btnCloseOLEDB.TabIndex = 5
        Me.btnCloseOLEDB.Text = "Close OLEDB"
        Me.btnCloseOLEDB.UseVisualStyleBackColor = True
        '
        'lblSQLConnectionState
        '
        Me.lblSQLConnectionState.AutoSize = True
        Me.lblSQLConnectionState.Location = New System.Drawing.Point(221, 57)
        Me.lblSQLConnectionState.Name = "lblSQLConnectionState"
        Me.lblSQLConnectionState.Size = New System.Drawing.Size(51, 17)
        Me.lblSQLConnectionState.TabIndex = 6
        Me.lblSQLConnectionState.Text = "Label1"
        '
        'lblOLEDBConnectionState
        '
        Me.lblOLEDBConnectionState.AutoSize = True
        Me.lblOLEDBConnectionState.Location = New System.Drawing.Point(221, 256)
        Me.lblOLEDBConnectionState.Name = "lblOLEDBConnectionState"
        Me.lblOLEDBConnectionState.Size = New System.Drawing.Size(51, 17)
        Me.lblOLEDBConnectionState.TabIndex = 7
        Me.lblOLEDBConnectionState.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOLEDBConnectionState)
        Me.Controls.Add(Me.lblSQLConnectionState)
        Me.Controls.Add(Me.btnCloseOLEDB)
        Me.Controls.Add(Me.btnGetOLEDBInfo)
        Me.Controls.Add(Me.btnOpenOleDB)
        Me.Controls.Add(Me.btnCloseSQL)
        Me.Controls.Add(Me.btnGetSQLInfo)
        Me.Controls.Add(Me.btnOpenSQL)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenSQL As Button
    Friend WithEvents btnGetSQLInfo As Button
    Friend WithEvents btnCloseSQL As Button
    Friend WithEvents btnOpenOleDB As Button
    Friend WithEvents btnGetOLEDBInfo As Button
    Friend WithEvents btnCloseOLEDB As Button
    Friend WithEvents lblSQLConnectionState As Label
    Friend WithEvents lblOLEDBConnectionState As Label
End Class
