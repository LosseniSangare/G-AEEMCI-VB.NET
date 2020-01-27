Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Module MES_VARIABLES

    Public CN As New MySqlConnection("server=localhost; user id = root ;password= ;database =aemci;")
    Public CN1 As New MySqlConnection("server=localhost; user id = root ;password= ;database =aemci;")

    Public cmd As New MySqlCommand
    Public cmd1 As New MySqlCommand


    Public dr As MySqlDataReader
    Public dr1 As MySqlDataReader


    Public niveau As String
    Public specialite As String
    Public compt As Integer = 0
    Public nbre As Integer
    Public NCE As String = "vide"
    Public NCE_PAR As String
    Public CEL As String
    Public ANNEE As String
    Public an1 As Integer
    Public an2 As Integer
End Module
