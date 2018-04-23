Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace DeleteAllListViewItems.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As DevExpress.ExpressApp.IObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			If ObjectSpace.FindObject(Of Contact)(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Doe'")) Is Nothing Then
				Dim contact As Contact = ObjectSpace.CreateObject(Of Contact)()
				contact.FirstName = "John"
				contact.LastName = "Doe"


				contact = ObjectSpace.CreateObject(Of Contact)()
				contact.FirstName = "Jesse"
				contact.LastName = "Black"


				contact = ObjectSpace.CreateObject(Of Contact)()
				contact.FirstName = "Sam"
				contact.LastName = "Brown"

				contact = ObjectSpace.CreateObject(Of Contact)()
				contact.FirstName = "Ann"
				contact.LastName = "Grant"

			End If

		End Sub
	End Class
End Namespace
