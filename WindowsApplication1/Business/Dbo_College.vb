Public Class Dbo_College

    Private m_name As String
    Private m_address As String
    Private m_affiliation As String


    Public Property MName() As String
        Get
            Return m_name
        End Get
        Set(ByVal value As String)
            m_name = value
        End Set
    End Property

    Public Property MAddress() As String
        Get
            Return m_address
        End Get
        Set(ByVal value As String)
            m_address = value
        End Set
    End Property


    Public Property MAffiliation() As String
        Get
            Return m_affiliation
        End Get
        Set(ByVal value As String)
            m_affiliation = value
        End Set
    End Property


End Class
