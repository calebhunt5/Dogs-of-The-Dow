Public Class frmA13
    'creation of constants for indexes in csv
    Const IDX_SYMBOL As Integer = 0
    Const IDX_NAME As Integer = 1
    Const IDX_2018 As Integer = 2
    Const IDX_2019 As Integer = 3

    'array that holds stores csv values
    Dim dogs() As String

    'creation of formats for header and company data
    Dim headerFormat As String = "{0, -20}|{1, 10}|{2, 15}|{3, 15}|{4, 15}"
    Dim dogsFormat As String = "{0, -20}|{1, 10}|{2, 15:N2}|{3, 15:N2}|{4, 15:p}"

    'form load is the only method in this program
    Private Sub frmA13_Load(sender As Object, e As EventArgs) Handles Me.Load
        'populates dogs with csv file data
        dogs = IO.File.ReadAllLines("DOW2019.txt")

        'output horizontal line
        lstDogs.Items.Add(StrDup(80, "-"))

        'query for company info
        Dim dogsQuery = From company In dogs
                        Let symbol = company.Split(","c)(IDX_SYMBOL)
                        Let name As String = company.Split(","c)(IDX_NAME)
                        Let prevYear = CDec(company.Split(","c)(IDX_2018))
                        Let nextYear = CDec(company.Split(","c)(IDX_2019))
                        Let priceDiff As Decimal = nextYear - prevYear
                        Let percentChange As Decimal = priceDiff / prevYear
                        Select symbol, name, prevYear, nextYear, percentChange

        'output header and another horizontal line
        lstDogs.Items.Add(String.Format(headerFormat,
                                        "Company",
                                        "Symbol",
                                        "Price 2018",
                                        "Price 2019",
                                        "Change %"))
        lstDogs.Items.Add(StrDup(80, "-"))

        'loop to output each company's info and a horizontal line
        For Each company In dogsQuery
            lstDogs.Items.Add(String.Format(dogsFormat,
                                            company.name,
                                            company.symbol,
                                            company.prevYear,
                                            company.nextYear,
                                            company.percentChange))
            lstDogs.Items.Add(String.Format(StrDup(80, "-")))
        Next
    End Sub
End Class
