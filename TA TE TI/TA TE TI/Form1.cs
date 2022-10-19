namespace TA_TE_TI
{
    public partial class FormTateti : Form
    {
           //Crearemos los botones de forma dinamica. Para ello empiezo creando una lista de botones

        List<Button> listaBotones = new List<Button>(); 

        public FormTateti()
        {
            InitializeComponent();
        }
        //Creador de los botones
        void CrearBotones()
        {
            //gestion de las coordenadas: left y top . Inicializados en la esquina sup drcha pero un poco apartado del marco
            int left=50;
            int top=50;  

            for (int i = 0; i < 9; i++)
            {
                var boton = new Button();       //Creo var botón
                //Inicializo el botón
                boton.Width = 80;
                boton.Height = 80;
                boton.Font = new Font(new FontFamily("Arial"), 18);
                boton.Visible = true;
                boton.Left=left;
                boton.Top=top;

                left += 150;

                if(i==2 || i == 5)      //ctrl cada vez que llego al tercer boton para bajar una fila. Nota: index "i" del boton empieza en 0 --> 31 boton: index 2...
                {
                    top += 150;
                    left = 50;
                }

                listaBotones.Add(boton);        //agrego el boton creado a la lista de botones
                this.Controls.Add(boton);       //Agrego el botón al frm

            }
        }

        //carga del frm
        private void FormTateti_Load(object sender, EventArgs e)
        {
            CrearBotones();             
        }
    }
}