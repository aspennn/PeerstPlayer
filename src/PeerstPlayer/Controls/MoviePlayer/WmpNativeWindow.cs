﻿using System;
using System.Windows.Forms;
using PeerstLib.Controls;

namespace PeerstPlayer.Controls.MoviePlayer
{
	//-------------------------------------------------------------
	// 概要：WMPウィンドウのサブクラス化
	//-------------------------------------------------------------
	class WmpNativeWindow : NativeWindow
	{
		//-------------------------------------------------------------
		// 公開プロパティ
		//-------------------------------------------------------------

		// ダブルクリックイベント
		public event EventHandler DoubleClick = delegate { };

		//-------------------------------------------------------------
		// 概要：コンストラクタ
		//-------------------------------------------------------------
		public WmpNativeWindow(IntPtr handle)
		{
			// サブクラスウィンドウの設定
			AssignHandle(handle);
		}

		//-------------------------------------------------------------
		// 概要：ウィンドウプロシージャ
		// 詳細：ダブルクリック押下のイベント通知
		//-------------------------------------------------------------
		protected override void WndProc(ref Message m)
		{
			switch ((WindowMessage)m.Msg)
			{
				case WindowMessage.WM_LBUTTONUP:
					DoubleClick(this, new EventArgs());
					break;

				case WindowMessage.WM_MOUSEMOVE:
					// マウスカーソルの更新
					Cursor.Current = Cursors.Arrow;
					break;

				default:
					break;
			}

			base.WndProc(ref m);
		}
	}
}