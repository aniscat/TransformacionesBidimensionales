using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransformacionesBidimensionales
{
    partial class Graficadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button BtnGraficar;
            System.Windows.Forms.Button BtnAñadir;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graficadora));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TabTransformaciones = new System.Windows.Forms.TabControl();
            this.TabPuntos = new System.Windows.Forms.TabPage();
            this.DataGridViewPuntos = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabRotar = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnRotar = new System.Windows.Forms.Button();
            this.TxtBxGrados = new System.Windows.Forms.TextBox();
            this.LblGrados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewRotaciones = new System.Windows.Forms.DataGridView();
            this.ColNombreR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGrados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColXR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColYR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColColorR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabEscalar = new System.Windows.Forms.TabPage();
            this.TabTraslacion = new System.Windows.Forms.TabPage();
            this.TabSesgado = new System.Windows.Forms.TabPage();
            this.BtnColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBxY = new System.Windows.Forms.TextBox();
            this.LabelY = new System.Windows.Forms.Label();
            this.TxtBxX = new System.Windows.Forms.TextBox();
            this.LabelX = new System.Windows.Forms.Label();
            this.pictureBoxGrafica = new System.Windows.Forms.PictureBox();
            this.toolTipEscribe = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            BtnGraficar = new System.Windows.Forms.Button();
            BtnAñadir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.TabTransformaciones.SuspendLayout();
            this.TabPuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPuntos)).BeginInit();
            this.TabRotar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRotaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGraficar
            // 
            BtnGraficar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            BtnGraficar.AutoSize = true;
            BtnGraficar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnGraficar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            BtnGraficar.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            BtnGraficar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            BtnGraficar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            BtnGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnGraficar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            BtnGraficar.ForeColor = System.Drawing.Color.Azure;
            BtnGraficar.Location = new System.Drawing.Point(258, 136);
            BtnGraficar.Name = "BtnGraficar";
            BtnGraficar.Size = new System.Drawing.Size(100, 40);
            BtnGraficar.TabIndex = 7;
            BtnGraficar.Text = "Graficar";
            this.toolTipEscribe.SetToolTip(BtnGraficar, "Presiona para graficar");
            BtnGraficar.UseVisualStyleBackColor = true;
            BtnGraficar.Click += new System.EventHandler(this.BtnGraficar_Click);
            // 
            // BtnAñadir
            // 
            BtnAñadir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            BtnAñadir.AutoSize = true;
            BtnAñadir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            BtnAñadir.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            BtnAñadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            BtnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            BtnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnAñadir.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            BtnAñadir.ForeColor = System.Drawing.Color.Azure;
            BtnAñadir.Location = new System.Drawing.Point(158, 136);
            BtnAñadir.Name = "BtnAñadir";
            BtnAñadir.Size = new System.Drawing.Size(87, 40);
            BtnAñadir.TabIndex = 9;
            BtnAñadir.Text = "Añadir";
            this.toolTipEscribe.SetToolTip(BtnAñadir, "Presiona para guardar el punto");
            BtnAñadir.UseVisualStyleBackColor = true;
            BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.TxtBxNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TabTransformaciones);
            this.groupBox1.Controls.Add(BtnAñadir);
            this.groupBox1.Controls.Add(this.BtnColor);
            this.groupBox1.Controls.Add(BtnGraficar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtBxY);
            this.groupBox1.Controls.Add(this.LabelY);
            this.groupBox1.Controls.Add(this.TxtBxX);
            this.groupBox1.Controls.Add(this.LabelX);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 661);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propiedades de puntosRotados";
            // 
            // TxtBxNombre
            // 
            this.TxtBxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxNombre.Location = new System.Drawing.Point(132, 48);
            this.TxtBxNombre.Name = "TxtBxNombre";
            this.TxtBxNombre.Size = new System.Drawing.Size(226, 28);
            this.TxtBxNombre.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 42);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 5, 5, 5);
            this.label2.Size = new System.Drawing.Size(101, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TabTransformaciones
            // 
            this.TabTransformaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabTransformaciones.Controls.Add(this.TabPuntos);
            this.TabTransformaciones.Controls.Add(this.TabRotar);
            this.TabTransformaciones.Controls.Add(this.TabEscalar);
            this.TabTransformaciones.Controls.Add(this.TabTraslacion);
            this.TabTransformaciones.Controls.Add(this.TabSesgado);
            this.TabTransformaciones.Location = new System.Drawing.Point(0, 183);
            this.TabTransformaciones.Name = "TabTransformaciones";
            this.TabTransformaciones.SelectedIndex = 0;
            this.TabTransformaciones.Size = new System.Drawing.Size(414, 478);
            this.TabTransformaciones.TabIndex = 10;
            // 
            // TabPuntos
            // 
            this.TabPuntos.Controls.Add(this.DataGridViewPuntos);
            this.TabPuntos.Location = new System.Drawing.Point(4, 25);
            this.TabPuntos.Name = "TabPuntos";
            this.TabPuntos.Size = new System.Drawing.Size(406, 449);
            this.TabPuntos.TabIndex = 4;
            this.TabPuntos.Text = "Puntos";
            this.TabPuntos.UseVisualStyleBackColor = true;
            // 
            // DataGridViewPuntos
            // 
            this.DataGridViewPuntos.AllowUserToOrderColumns = true;
            this.DataGridViewPuntos.ColumnHeadersHeight = 29;
            this.DataGridViewPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColX,
            this.ColY,
            this.ColColor});
            this.DataGridViewPuntos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewPuntos.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewPuntos.Name = "DataGridViewPuntos";
            this.DataGridViewPuntos.RowHeadersVisible = false;
            this.DataGridViewPuntos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewPuntos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewPuntos.RowTemplate.Height = 24;
            this.DataGridViewPuntos.Size = new System.Drawing.Size(406, 449);
            this.DataGridViewPuntos.TabIndex = 0;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Width = 125;
            // 
            // ColX
            // 
            this.ColX.HeaderText = "X";
            this.ColX.MinimumWidth = 6;
            this.ColX.Name = "ColX";
            this.ColX.Width = 125;
            // 
            // ColY
            // 
            this.ColY.HeaderText = "Y";
            this.ColY.MinimumWidth = 6;
            this.ColY.Name = "ColY";
            this.ColY.Width = 125;
            // 
            // ColColor
            // 
            this.ColColor.HeaderText = "Color";
            this.ColColor.MinimumWidth = 6;
            this.ColColor.Name = "ColColor";
            this.ColColor.Width = 125;
            // 
            // TabRotar
            // 
            this.TabRotar.Controls.Add(this.panel2);
            this.TabRotar.Controls.Add(this.panel1);
            this.TabRotar.Location = new System.Drawing.Point(4, 25);
            this.TabRotar.Name = "TabRotar";
            this.TabRotar.Padding = new System.Windows.Forms.Padding(3);
            this.TabRotar.Size = new System.Drawing.Size(406, 449);
            this.TabRotar.TabIndex = 0;
            this.TabRotar.Text = "Rotación";
            this.TabRotar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.BtnRotar);
            this.panel2.Controls.Add(this.TxtBxGrados);
            this.panel2.Controls.Add(this.LblGrados);
            this.panel2.Location = new System.Drawing.Point(3, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 110);
            this.panel2.TabIndex = 5;
            // 
            // BtnRotar
            // 
            this.BtnRotar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnRotar.AutoSize = true;
            this.BtnRotar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRotar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRotar.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.BtnRotar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnRotar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BtnRotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRotar.ForeColor = System.Drawing.Color.Azure;
            this.BtnRotar.Location = new System.Drawing.Point(262, 30);
            this.BtnRotar.Name = "BtnRotar";
            this.BtnRotar.Size = new System.Drawing.Size(100, 37);
            this.BtnRotar.TabIndex = 1;
            this.BtnRotar.Text = "   Rotar   ";
            this.BtnRotar.UseVisualStyleBackColor = false;
            this.BtnRotar.Click += new System.EventHandler(this.BtnRotar_Click);
            // 
            // TxtBxGrados
            // 
            this.TxtBxGrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TxtBxGrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxGrados.Location = new System.Drawing.Point(117, 37);
            this.TxtBxGrados.Name = "TxtBxGrados";
            this.TxtBxGrados.Size = new System.Drawing.Size(212, 27);
            this.TxtBxGrados.TabIndex = 2;
            // 
            // LblGrados
            // 
            this.LblGrados.AutoSize = true;
            this.LblGrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrados.ForeColor = System.Drawing.Color.DarkCyan;
            this.LblGrados.Location = new System.Drawing.Point(36, 37);
            this.LblGrados.Name = "LblGrados";
            this.LblGrados.Size = new System.Drawing.Size(76, 25);
            this.LblGrados.TabIndex = 3;
            this.LblGrados.Text = "Grados";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dataGridViewRotaciones);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 344);
            this.panel1.TabIndex = 4;
            // 
            // dataGridViewRotaciones
            // 
            this.dataGridViewRotaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRotaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombreR,
            this.ColGrados,
            this.ColXR,
            this.ColYR,
            this.ColColorR});
            this.dataGridViewRotaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRotaciones.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRotaciones.Name = "dataGridViewRotaciones";
            this.dataGridViewRotaciones.RowHeadersWidth = 51;
            this.dataGridViewRotaciones.RowTemplate.Height = 24;
            this.dataGridViewRotaciones.Size = new System.Drawing.Size(406, 344);
            this.dataGridViewRotaciones.TabIndex = 0;
            // 
            // ColNombreR
            // 
            this.ColNombreR.HeaderText = "Nombre";
            this.ColNombreR.MinimumWidth = 6;
            this.ColNombreR.Name = "ColNombreR";
            this.ColNombreR.Width = 125;
            // 
            // ColGrados
            // 
            this.ColGrados.HeaderText = "Grados";
            this.ColGrados.MinimumWidth = 6;
            this.ColGrados.Name = "ColGrados";
            this.ColGrados.Width = 125;
            // 
            // ColXR
            // 
            this.ColXR.HeaderText = "X";
            this.ColXR.MinimumWidth = 6;
            this.ColXR.Name = "ColXR";
            this.ColXR.Width = 125;
            // 
            // ColYR
            // 
            this.ColYR.HeaderText = "Y";
            this.ColYR.MinimumWidth = 6;
            this.ColYR.Name = "ColYR";
            this.ColYR.Width = 125;
            // 
            // ColColorR
            // 
            this.ColColorR.HeaderText = "Color";
            this.ColColorR.MinimumWidth = 6;
            this.ColColorR.Name = "ColColorR";
            this.ColColorR.Width = 125;
            // 
            // TabEscalar
            // 
            this.TabEscalar.Location = new System.Drawing.Point(4, 25);
            this.TabEscalar.Name = "TabEscalar";
            this.TabEscalar.Padding = new System.Windows.Forms.Padding(3);
            this.TabEscalar.Size = new System.Drawing.Size(406, 449);
            this.TabEscalar.TabIndex = 1;
            this.TabEscalar.Text = "Escalamiento";
            this.TabEscalar.UseVisualStyleBackColor = true;
            // 
            // TabTraslacion
            // 
            this.TabTraslacion.Location = new System.Drawing.Point(4, 25);
            this.TabTraslacion.Name = "TabTraslacion";
            this.TabTraslacion.Size = new System.Drawing.Size(406, 449);
            this.TabTraslacion.TabIndex = 2;
            this.TabTraslacion.Text = "Traslación";
            this.TabTraslacion.UseVisualStyleBackColor = true;
            // 
            // TabSesgado
            // 
            this.TabSesgado.Location = new System.Drawing.Point(4, 25);
            this.TabSesgado.Name = "TabSesgado";
            this.TabSesgado.Size = new System.Drawing.Size(406, 449);
            this.TabSesgado.TabIndex = 3;
            this.TabSesgado.Text = "Sesgado";
            this.TabSesgado.UseVisualStyleBackColor = true;
            // 
            // BtnColor
            // 
            this.BtnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnColor.AutoSize = true;
            this.BtnColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnColor.Location = new System.Drawing.Point(113, 147);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(26, 26);
            this.BtnColor.TabIndex = 8;
            this.BtnColor.Text = "...";
            this.toolTipEscribe.SetToolTip(this.BtnColor, "Selecciona un color");
            this.BtnColor.UseVisualStyleBackColor = false;
            this.BtnColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Color";
            // 
            // TxtBxY
            // 
            this.TxtBxY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxY.Location = new System.Drawing.Point(254, 105);
            this.TxtBxY.Name = "TxtBxY";
            this.TxtBxY.Size = new System.Drawing.Size(100, 28);
            this.TxtBxY.TabIndex = 5;
            // 
            // LabelY
            // 
            this.LabelY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelY.AutoSize = true;
            this.LabelY.CausesValidation = false;
            this.LabelY.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelY.Location = new System.Drawing.Point(213, 95);
            this.LabelY.Name = "LabelY";
            this.LabelY.Padding = new System.Windows.Forms.Padding(7, 5, 5, 5);
            this.LabelY.Size = new System.Drawing.Size(35, 38);
            this.LabelY.TabIndex = 4;
            this.LabelY.Text = "y";
            // 
            // TxtBxX
            // 
            this.TxtBxX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxX.Location = new System.Drawing.Point(75, 105);
            this.TxtBxX.Name = "TxtBxX";
            this.TxtBxX.Size = new System.Drawing.Size(100, 28);
            this.TxtBxX.TabIndex = 3;
            // 
            // LabelX
            // 
            this.LabelX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelX.AutoSize = true;
            this.LabelX.CausesValidation = false;
            this.LabelX.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX.Location = new System.Drawing.Point(34, 95);
            this.LabelX.Name = "LabelX";
            this.LabelX.Padding = new System.Windows.Forms.Padding(7, 5, 5, 5);
            this.LabelX.Size = new System.Drawing.Size(35, 38);
            this.LabelX.TabIndex = 2;
            this.LabelX.Text = "x";
            // 
            // pictureBoxGrafica
            // 
            this.pictureBoxGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGrafica.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pictureBoxGrafica.Location = new System.Drawing.Point(432, 12);
            this.pictureBoxGrafica.Name = "pictureBoxGrafica";
            this.pictureBoxGrafica.Size = new System.Drawing.Size(673, 637);
            this.pictureBoxGrafica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGrafica.TabIndex = 1;
            this.pictureBoxGrafica.TabStop = false;
            this.pictureBoxGrafica.WaitOnLoad = true;
            this.pictureBoxGrafica.Click += new System.EventHandler(this.pictureBoxGrafica_Click);
            this.pictureBoxGrafica.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGrafica_Paint);
            this.pictureBoxGrafica.Resize += new System.EventHandler(this.Graficadora_SizeChanged);
            // 
            // toolTipEscribe
            // 
            this.toolTipEscribe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolTipEscribe.IsBalloon = true;
            // 
            // Graficadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1117, 661);
            this.Controls.Add(this.pictureBoxGrafica);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graficadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SizeChanged += new System.EventHandler(this.Graficadora_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabTransformaciones.ResumeLayout(false);
            this.TabPuntos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPuntos)).EndInit();
            this.TabRotar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRotaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrafica)).EndInit();
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBxX;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.TextBox TxtBxY;
        private System.Windows.Forms.Label LabelY;
        private System.Windows.Forms.PictureBox pictureBoxGrafica;
        private System.Windows.Forms.ToolTip toolTipEscribe;
        private ColorDialog colorDialog1;
        private Label label1;
        private Button BtnColor;
        private Color color;
        int xcentro;
        int ycentro;
        private TabControl TabTransformaciones;
        private TabPage TabPuntos;
        private TabPage TabRotar;
        private TabPage TabEscalar;
        private TabPage TabTraslacion;
        private TabPage TabSesgado;
        private DataGridView DataGridViewPuntos;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColX;
        private DataGridViewTextBoxColumn ColY;
        private DataGridViewTextBoxColumn ColColor;
        private Label LblGrados;
        private TextBox TxtBxGrados;
        private Button BtnRotar;
        private DataGridView dataGridViewRotaciones;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn ColNombreR;
        private DataGridViewTextBoxColumn ColGrados;
        private DataGridViewTextBoxColumn ColXR;
        private DataGridViewTextBoxColumn ColYR;
        private DataGridViewTextBoxColumn ColColorR;
        private TextBox TxtBxNombre;
        private Label label2;
    }
}

