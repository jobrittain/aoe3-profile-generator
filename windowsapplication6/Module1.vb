Imports System.Xml
Imports System.Text

Module WriteXML

        Public City As String
        Public Exp As String
        Public ExpD As String
        Public Ship As String
        Public GT As String
        Public Civ As String
        Public Level As Integer
        Public XP As Integer
        Public SP As Integer

        Sub Main()

        City = MainForm.CitBox.Text
        Exp = MainForm.ExpBox.Text
        ExpD = MainForm.ExpDBox.Text
        Ship = MainForm.SBox.Text
        GT = MainForm.GBox.Text
        Civ = MainForm.CBox.Text
        Level = MainForm.LBox.Value
        XP = MainForm.XPBox.Value
        SP = MainForm.SPBox.Value


            ' Create XmlWriterSettings.
            Dim WriterSettings As XmlWriterSettings = New XmlWriterSettings()
        WriterSettings.Indent = True
        WriterSettings.Encoding = System.Text.Encoding.Unicode

            Dim MyDocsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        ' Create XmlWriter.
        Try
            Using Writer As XmlWriter = XmlWriter.Create(MyDocsFolder & "\My Games\Age of Empires 3\Savegame\sp_" & City & "_homecity.xml", WriterSettings)
                ' Begin writing.
                'Writer.WriteProcessingInstruction("xml", "version='1.0'")
                Writer.WriteStartDocument()
                Writer.WriteStartElement("savedhomecity", "1") ' Root.

                Writer.WriteElementString("defaultdirectoryid", "0")
                Writer.WriteElementString("defaultfilename", "homecity" & Civ & ".xml")
                Writer.WriteElementString("civ", Civ)
                Writer.WriteElementString("hctype", "HC")
                Writer.WriteElementString("name", City)
                Writer.WriteElementString("heroname", Exp)
                Writer.WriteElementString("herodogname", ExpD)
                Writer.WriteElementString("shipname", Ship)
                Writer.WriteElementString("hcid", "")
                Writer.WriteElementString("respec", "1")
                Writer.WriteElementString("level", Level)
                Writer.WriteElementString("xp", XP)
                Writer.WriteElementString("skillpoints", SP)
                Writer.WriteElementString("xppercentage", "0.800000")
                Writer.WriteElementString("numpropunlocksearned", "0")
                Writer.WriteElementString("decks", "")
                Writer.WriteElementString("activetechs", "")
                Writer.WriteElementString("activeprops", "")

                Writer.WriteEndElement()
                ' End document.
                Writer.WriteEndDocument()
            End Using
            MsgBox("Profile Generated.", MsgBoxStyle.Information, "Success")
        Catch
            MsgBox("Profile Generation Error!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module
