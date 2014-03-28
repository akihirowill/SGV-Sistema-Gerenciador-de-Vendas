namespace Frm_Splash
{
    partial class Frm_Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Vendas));
            this.dgrEstoque = new System.Windows.Forms.DataGridView();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.TOTAL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVender = new System.Windows.Forms.Button();
            this.dgrVendas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblTotal = new System.Windows.Forms.PictureBox();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblqtd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrEstoque
            // 
            this.dgrEstoque.AllowUserToAddRows = false;
            this.dgrEstoque.AllowUserToDeleteRows = false;
            this.dgrEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrEstoque.Location = new System.Drawing.Point(3, 56);
            this.dgrEstoque.Name = "dgrEstoque";
            this.dgrEstoque.ReadOnly = true;
            this.dgrEstoque.RowTemplate.DefaultCellStyle.NullValue = "Null";
            this.dgrEstoque.Size = new System.Drawing.Size(444, 260);
            this.dgrEstoque.TabIndex = 1;
            this.dgrEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrEstoque_CellClick);
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(49, 19);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(79, 20);
            this.nudQtd.TabIndex = 2;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.btnRemover);
            this.groupbox1.Controls.Add(this.btnAdicionar);
            this.groupbox1.Controls.Add(this.nudQtd);
            this.groupbox1.Location = new System.Drawing.Point(453, 92);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(178, 178);
            this.groupbox1.TabIndex = 3;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "QUANTIDADE";
            // 
            // btnRemover
            // 
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.Location = new System.Drawing.Point(31, 111);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(122, 42);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.Location = new System.Drawing.Point(30, 56);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(123, 39);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.BackColor = System.Drawing.Color.Transparent;
            this.TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.Location = new System.Drawing.Point(84, 352);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(107, 31);
            this.TOTAL.TabIndex = 6;
            this.TOTAL.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "DINHEIRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(881, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "TROCO";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Red;
            this.lbl_total.Location = new System.Drawing.Point(69, 420);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(133, 61);
            this.lbl_total.TabIndex = 9;
            this.lbl_total.Text = "0,00";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.Lime;
            this.lblTroco.Location = new System.Drawing.Point(876, 420);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(133, 61);
            this.lblTroco.TabIndex = 10;
            this.lblTroco.Text = "0,00";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(468, 319);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(156, 20);
            this.txtDinheiro.TabIndex = 11;
            this.txtDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinheiro_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(384, 364);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(27, 28);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(453, 364);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(185, 104);
            this.btnVender.TabIndex = 13;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // dgrVendas
            // 
            this.dgrVendas.AllowUserToAddRows = false;
            this.dgrVendas.AllowUserToOrderColumns = true;
            this.dgrVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProdutoVenda,
            this.PrecoVenda,
            this.Quantidade});
            this.dgrVendas.Location = new System.Drawing.Point(637, 56);
            this.dgrVendas.Name = "dgrVendas";
            this.dgrVendas.Size = new System.Drawing.Size(444, 260);
            this.dgrVendas.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // ProdutoVenda
            // 
            this.ProdutoVenda.HeaderText = "Produto";
            this.ProdutoVenda.Name = "ProdutoVenda";
            this.ProdutoVenda.ReadOnly = true;
            // 
            // PrecoVenda
            // 
            this.PrecoVenda.HeaderText = "Preço";
            this.PrecoVenda.Name = "PrecoVenda";
            this.PrecoVenda.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1090, 523);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(12, 287);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.SystemColors.Desktop;
            this.rectangleShape1.Size = new System.Drawing.Size(449, 205);
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Image = global::Frm_Splash.Properties.Resources.back3;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(1090, 523);
            this.lblTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblTotal.TabIndex = 0;
            this.lblTotal.TabStop = false;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(383, 338);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(35, 13);
            this.lbldata.TabIndex = 14;
            this.lbldata.Text = "label1";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(328, 380);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "label1";
            // 
            // lblqtd
            // 
            this.lblqtd.AutoSize = true;
            this.lblqtd.Location = new System.Drawing.Point(320, 341);
            this.lblqtd.Name = "lblqtd";
            this.lblqtd.Size = new System.Drawing.Size(35, 13);
            this.lblqtd.TabIndex = 16;
            this.lblqtd.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Produto";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(93, 21);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(354, 20);
            this.txtConsulta.TabIndex = 19;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // Frm_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.dgrVendas);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.dgrEstoque);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblqtd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Vendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgrEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            this.groupbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrEstoque;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.DataGridView dgrVendas;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.PictureBox lblTotal;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblqtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConsulta;
    }
}