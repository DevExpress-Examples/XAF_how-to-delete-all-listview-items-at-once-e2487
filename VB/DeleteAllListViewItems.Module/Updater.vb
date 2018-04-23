Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace DeleteAllListViewItems.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			If Session.FindObject(Of Contact)(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Doe'")) Is Nothing Then
				Dim contact As New Contact(Session)
				contact.FirstName = "John"
				contact.LastName = "Doe"
				contact.Save()

				contact = New Contact(Session)
				contact.FirstName = "Jesse"
				contact.LastName = "Black"
				contact.Save()

				contact = New Contact(Session)
				contact.FirstName = "Sam"
				contact.LastName = "Brown"
				contact.Save()

				contact = New Contact(Session)
				contact.FirstName = "Ann"
				contact.LastName = "Grant"
				contact.Save()

			End If

		End Sub
	End Class
End Namespace
