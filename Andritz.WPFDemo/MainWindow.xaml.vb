Imports System.Collections.ObjectModel

Class MainWindow

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim vm As New MainWindowViewModel
        'txtAnzahl.Text = vm.AnzahlMaschinen
        'img1.ImageSource=vm.Logo
        vm.AnzahlMaschinen = 7
        vm.Hintergrundfarbe = "Blue"
        vm.Logo = "Andritz.png"
        vm.Maschinen = New ObservableCollection(Of Maschine)
        Dim m1 As New Maschine
        m1.Id = 1
        m1.Bezeichnung = "Andritz V1"
        Dim m2 As New Maschine
        m2.Id = 2
        m2.Bezeichnung = "Andritz VX2"
        vm.Maschinen.Add(m1)
        vm.Maschinen.Add(m2)
        Me.DataContext = vm

        'Class-Library DB-Zugriff
        'WPF - ViewModel - Databinding

    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        MsgBox("Hello Andritz")
    End Sub

    Private Sub Button_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
        Me.Title = "Doppelt " & DateTime.Now.ToLongTimeString
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim windowEingabe As New WindowMaschinenEingabe
        windowEingabe.Show()
    End Sub

    Dim counter As Int16 = 0
    Private Sub RepeatButton_Click(sender As Object, e As RoutedEventArgs)
        counter += 1
        Me.Title = "Zähler " & counter
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Tab4.Visibility = Visibility.Visible
    End Sub

    Private Sub ListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        Dim l As ListBox = CType(sender, ListBox)
        Dim lItem As ListBoxItem = CType(l.SelectedItem, ListBoxItem)
        Me.Title = lItem.Content.ToString()
    End Sub
End Class
