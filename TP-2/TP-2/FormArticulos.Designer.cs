﻿namespace TP_2
{
    partial class FormArticulos
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
            this.lblArticulosFormArticulos = new System.Windows.Forms.Label();
            this.lvArticulosFormArticulos = new System.Windows.Forms.ListView();
            this.btnAgregarFormArticulos = new System.Windows.Forms.Button();
            this.btnModificarFormArticulos = new System.Windows.Forms.Button();
            this.btnEliminarFormArticulos = new System.Windows.Forms.Button();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.gpSeccionesFormArticulos = new System.Windows.Forms.GroupBox();
            this.gBoxBusquedaRapida = new System.Windows.Forms.GroupBox();
            this.txtBusquedaRapida = new System.Windows.Forms.TextBox();
            this.gBoxFiltrado = new System.Windows.Forms.GroupBox();
            this.txtBuscarFiltrado = new System.Windows.Forms.TextBox();
            this.cBoxCriterio = new System.Windows.Forms.ComboBox();
            this.cBoxCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnBuscarFiltrado = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.gpSeccionesFormArticulos.SuspendLayout();
            this.gBoxBusquedaRapida.SuspendLayout();
            this.gBoxFiltrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArticulosFormArticulos
            // 
            this.lblArticulosFormArticulos.AutoSize = true;
            this.lblArticulosFormArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosFormArticulos.Location = new System.Drawing.Point(279, 9);
            this.lblArticulosFormArticulos.Name = "lblArticulosFormArticulos";
            this.lblArticulosFormArticulos.Size = new System.Drawing.Size(207, 55);
            this.lblArticulosFormArticulos.TabIndex = 0;
            this.lblArticulosFormArticulos.Text = "Articulos";
            this.lblArticulosFormArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvArticulosFormArticulos
            // 
            this.lvArticulosFormArticulos.HideSelection = false;
            this.lvArticulosFormArticulos.Location = new System.Drawing.Point(173, 102);
            this.lvArticulosFormArticulos.Name = "lvArticulosFormArticulos";
            this.lvArticulosFormArticulos.Size = new System.Drawing.Size(508, 224);
            this.lvArticulosFormArticulos.TabIndex = 1;
            this.lvArticulosFormArticulos.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregarFormArticulos
            // 
            this.btnAgregarFormArticulos.Location = new System.Drawing.Point(22, 19);
            this.btnAgregarFormArticulos.Name = "btnAgregarFormArticulos";
            this.btnAgregarFormArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarFormArticulos.TabIndex = 2;
            this.btnAgregarFormArticulos.Text = "Agregar";
            this.btnAgregarFormArticulos.UseVisualStyleBackColor = true;
            // 
            // btnModificarFormArticulos
            // 
            this.btnModificarFormArticulos.Location = new System.Drawing.Point(22, 56);
            this.btnModificarFormArticulos.Name = "btnModificarFormArticulos";
            this.btnModificarFormArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnModificarFormArticulos.TabIndex = 3;
            this.btnModificarFormArticulos.Text = "Modificar";
            this.btnModificarFormArticulos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarFormArticulos
            // 
            this.btnEliminarFormArticulos.Location = new System.Drawing.Point(22, 93);
            this.btnEliminarFormArticulos.Name = "btnEliminarFormArticulos";
            this.btnEliminarFormArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarFormArticulos.TabIndex = 4;
            this.btnEliminarFormArticulos.Text = "Eliminar";
            this.btnEliminarFormArticulos.UseVisualStyleBackColor = true;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Location = new System.Drawing.Point(22, 130);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnVerDetalles.TabIndex = 5;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            // 
            // gpSeccionesFormArticulos
            // 
            this.gpSeccionesFormArticulos.Controls.Add(this.btnAgregarFormArticulos);
            this.gpSeccionesFormArticulos.Controls.Add(this.btnVerDetalles);
            this.gpSeccionesFormArticulos.Controls.Add(this.btnModificarFormArticulos);
            this.gpSeccionesFormArticulos.Controls.Add(this.btnEliminarFormArticulos);
            this.gpSeccionesFormArticulos.Location = new System.Drawing.Point(12, 102);
            this.gpSeccionesFormArticulos.Name = "gpSeccionesFormArticulos";
            this.gpSeccionesFormArticulos.Size = new System.Drawing.Size(122, 169);
            this.gpSeccionesFormArticulos.TabIndex = 6;
            this.gpSeccionesFormArticulos.TabStop = false;
            this.gpSeccionesFormArticulos.Text = "Secciones";
            // 
            // gBoxBusquedaRapida
            // 
            this.gBoxBusquedaRapida.Controls.Add(this.txtBusquedaRapida);
            this.gBoxBusquedaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxBusquedaRapida.Location = new System.Drawing.Point(12, 287);
            this.gBoxBusquedaRapida.Name = "gBoxBusquedaRapida";
            this.gBoxBusquedaRapida.Size = new System.Drawing.Size(140, 57);
            this.gBoxBusquedaRapida.TabIndex = 7;
            this.gBoxBusquedaRapida.TabStop = false;
            this.gBoxBusquedaRapida.Text = "Busqueda rapida";
            // 
            // txtBusquedaRapida
            // 
            this.txtBusquedaRapida.Location = new System.Drawing.Point(6, 21);
            this.txtBusquedaRapida.Name = "txtBusquedaRapida";
            this.txtBusquedaRapida.Size = new System.Drawing.Size(128, 22);
            this.txtBusquedaRapida.TabIndex = 0;
            // 
            // gBoxFiltrado
            // 
            this.gBoxFiltrado.Controls.Add(this.btnLimpiarFiltro);
            this.gBoxFiltrado.Controls.Add(this.btnBuscarFiltrado);
            this.gBoxFiltrado.Controls.Add(this.txtBuscarFiltrado);
            this.gBoxFiltrado.Controls.Add(this.cBoxCriterio);
            this.gBoxFiltrado.Controls.Add(this.cBoxCampo);
            this.gBoxFiltrado.Controls.Add(this.lblFiltro);
            this.gBoxFiltrado.Controls.Add(this.lblCriterio);
            this.gBoxFiltrado.Controls.Add(this.lblCampo);
            this.gBoxFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxFiltrado.Location = new System.Drawing.Point(12, 350);
            this.gBoxFiltrado.Name = "gBoxFiltrado";
            this.gBoxFiltrado.Size = new System.Drawing.Size(501, 128);
            this.gBoxFiltrado.TabIndex = 8;
            this.gBoxFiltrado.TabStop = false;
            this.gBoxFiltrado.Text = "Filtrar";
            // 
            // txtBuscarFiltrado
            // 
            this.txtBuscarFiltrado.Location = new System.Drawing.Point(384, 50);
            this.txtBuscarFiltrado.Name = "txtBuscarFiltrado";
            this.txtBuscarFiltrado.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarFiltrado.TabIndex = 5;
            // 
            // cBoxCriterio
            // 
            this.cBoxCriterio.FormattingEnabled = true;
            this.cBoxCriterio.Location = new System.Drawing.Point(203, 50);
            this.cBoxCriterio.Name = "cBoxCriterio";
            this.cBoxCriterio.Size = new System.Drawing.Size(121, 24);
            this.cBoxCriterio.TabIndex = 4;
            // 
            // cBoxCampo
            // 
            this.cBoxCampo.FormattingEnabled = true;
            this.cBoxCampo.Location = new System.Drawing.Point(28, 50);
            this.cBoxCampo.Name = "cBoxCampo";
            this.cBoxCampo.Size = new System.Drawing.Size(121, 24);
            this.cBoxCampo.TabIndex = 3;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(381, 26);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(46, 16);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(200, 26);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(57, 16);
            this.lblCriterio.TabIndex = 1;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(25, 31);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(60, 16);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo:";
            // 
            // btnBuscarFiltrado
            // 
            this.btnBuscarFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFiltrado.Location = new System.Drawing.Point(139, 93);
            this.btnBuscarFiltrado.Name = "btnBuscarFiltrado";
            this.btnBuscarFiltrado.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFiltrado.TabIndex = 6;
            this.btnBuscarFiltrado.Text = "Buscar";
            this.btnBuscarFiltrado.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(300, 93);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltro.TabIndex = 7;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.gBoxFiltrado);
            this.Controls.Add(this.gBoxBusquedaRapida);
            this.Controls.Add(this.gpSeccionesFormArticulos);
            this.Controls.Add(this.lvArticulosFormArticulos);
            this.Controls.Add(this.lblArticulosFormArticulos);
            this.Name = "FormArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormArticulos";
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            this.gpSeccionesFormArticulos.ResumeLayout(false);
            this.gBoxBusquedaRapida.ResumeLayout(false);
            this.gBoxBusquedaRapida.PerformLayout();
            this.gBoxFiltrado.ResumeLayout(false);
            this.gBoxFiltrado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulosFormArticulos;
        private System.Windows.Forms.ListView lvArticulosFormArticulos;
        private System.Windows.Forms.Button btnAgregarFormArticulos;
        private System.Windows.Forms.Button btnModificarFormArticulos;
        private System.Windows.Forms.Button btnEliminarFormArticulos;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.GroupBox gpSeccionesFormArticulos;
        private System.Windows.Forms.GroupBox gBoxBusquedaRapida;
        private System.Windows.Forms.TextBox txtBusquedaRapida;
        private System.Windows.Forms.GroupBox gBoxFiltrado;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.TextBox txtBuscarFiltrado;
        private System.Windows.Forms.ComboBox cBoxCriterio;
        private System.Windows.Forms.ComboBox cBoxCampo;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Button btnBuscarFiltrado;
    }
}