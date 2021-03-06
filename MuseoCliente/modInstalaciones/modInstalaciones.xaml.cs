﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MuseoCliente
{
	/// <summary>
	/// Lógica de interacción para modInstalaciones.xaml
	/// </summary>
	public partial class modInstalaciones : UserControl
	{
        Connection.Objects.Sala salas = new Connection.Objects.Sala();
        Connection.Objects.Caja cajas = new Connection.Objects.Caja();
        Connection.Objects.Vitrina vitrinas = new Connection.Objects.Vitrina();
        Connection.Objects.Pieza piezas = new Connection.Objects.Pieza();
        public Border borde;
        public modInstalaciones()
		{
			this.InitializeComponent();
		}

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            gvSalas.ItemsSource = salas.regresarTodos();
            gvCajas.ItemsSource = cajas.regresarTodo();
            gvVitrinas.ItemsSource = vitrinas.regresarTodos();
            gvPiezas.ItemsSource = piezas.buscarBodega();
        }

        private void btnNuevaSala_Click(object sender, RoutedEventArgs e)
        {
            modSala frm = new modSala();
            frm.borde = borde;
            frm.anterior = this;
            borde.Child = frm;
        }

        private void btnNuevaVitrina_Click(object sender, RoutedEventArgs e)
        {
            modVitrina frm = new modVitrina();
            frm.borde = borde;
            frm.anterior = this;
            borde.Child = frm;
        }

        private void btnNuevaCaja_Click(object sender, RoutedEventArgs e)
        {
            modCaja frm = new modCaja();
            frm.borde = borde;
            frm.anterior = this;
            borde.Child = frm;
        }

        private void btnTraslado_Click(object sender, RoutedEventArgs e)
        {
            modTraslado frm = new modTraslado();
            frm.borde = borde;
            frm.anterior = this;
            borde.Child = frm;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            modResultadosInst frm = new modResultadosInst();
            frm.busqueda = txtBuscar.Text;
            frm.borde = borde;
            frm.anterior = this;
            borde.Child = frm;
        }
	}
}