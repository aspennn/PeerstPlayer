﻿using PeerstLib.Controls;
using PeerstPlayer.Controls.PecaPlayer;
using PeerstPlayer.Controls.StatusBar;
namespace PeerstPlayer.Forms.Setting
{
	partial class PlayerView
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerView));
			this.toolStrip = new PeerstLib.Controls.ToolStripEx();
			this.minToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.maxToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.statusBar = new PeerstPlayer.Controls.StatusBar.StatusBarControl();
			this.pecaPlayer = new PeerstPlayer.Controls.PecaPlayer.PecaPlayerControl();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scale50PerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scale75PerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scale100PerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scale150PerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scale200PerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sizeToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.size160x120ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.size320x240ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.size480x360ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.size640x480ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.size800x600ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wmpMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip.GripMargin = new System.Windows.Forms.Padding(0);
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minToolStripButton,
            this.maxToolStripButton,
            this.closeToolStripButton});
			this.toolStrip.Location = new System.Drawing.Point(410, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
			this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip.Size = new System.Drawing.Size(71, 25);
			this.toolStrip.TabIndex = 3;
			// 
			// minToolStripButton
			// 
			this.minToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.minToolStripButton.Font = new System.Drawing.Font("Marlett", 9F);
			this.minToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("minToolStripButton.Image")));
			this.minToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.minToolStripButton.Name = "minToolStripButton";
			this.minToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.minToolStripButton.Text = "0";
			this.minToolStripButton.ToolTipText = "最小化";
			// 
			// maxToolStripButton
			// 
			this.maxToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.maxToolStripButton.Font = new System.Drawing.Font("Marlett", 9F);
			this.maxToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("maxToolStripButton.Image")));
			this.maxToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.maxToolStripButton.Name = "maxToolStripButton";
			this.maxToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.maxToolStripButton.Text = "1";
			this.maxToolStripButton.ToolTipText = "最大化";
			// 
			// closeToolStripButton
			// 
			this.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.closeToolStripButton.Font = new System.Drawing.Font("Marlett", 9F);
			this.closeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripButton.Image")));
			this.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.closeToolStripButton.Name = "closeToolStripButton";
			this.closeToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.closeToolStripButton.Text = "r";
			this.closeToolStripButton.ToolTipText = "閉じる";
			// 
			// statusBar
			// 
			this.statusBar.ChannelDetail = "チャンネル情報";
			this.statusBar.Location = new System.Drawing.Point(0, 360);
			this.statusBar.Margin = new System.Windows.Forms.Padding(0);
			this.statusBar.MovieStatus = "";
			this.statusBar.Name = "statusBar";
			this.statusBar.SelectThreadUrl = null;
			this.statusBar.Size = new System.Drawing.Size(480, 18);
			this.statusBar.TabIndex = 1;
			this.statusBar.Volume = "50";
			this.statusBar.WriteFieldVisible = false;
			// 
			// pecaPlayer
			// 
			this.pecaPlayer.ChannelInfo = null;
			this.pecaPlayer.ClickPoint = new System.Drawing.Point(0, 0);
			this.pecaPlayer.EnableContextMenu = false;
			this.pecaPlayer.Location = new System.Drawing.Point(0, 0);
			this.pecaPlayer.Margin = new System.Windows.Forms.Padding(0);
			this.pecaPlayer.Mute = false;
			this.pecaPlayer.Name = "pecaPlayer";
			this.pecaPlayer.Size = new System.Drawing.Size(480, 360);
			this.pecaPlayer.TabIndex = 0;
			this.pecaPlayer.Volume = 50;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SizeToolStripMenuItem,
            this.wmpMenuToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(154, 76);
			// 
			// SizeToolStripMenuItem
			// 
			this.SizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scale50PerToolStripMenuItem,
            this.scale75PerToolStripMenuItem,
            this.scale100PerToolStripMenuItem,
            this.scale150PerToolStripMenuItem,
            this.scale200PerToolStripMenuItem,
            this.sizeToolStripSeparator,
            this.size160x120ToolStripMenuItem,
            this.size320x240ToolStripMenuItem,
            this.size480x360ToolStripMenuItem,
            this.size640x480ToolStripMenuItem,
            this.size800x600ToolStripMenuItem});
			this.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem";
			this.SizeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.SizeToolStripMenuItem.Text = "サイズ";
			// 
			// scale50PerToolStripMenuItem
			// 
			this.scale50PerToolStripMenuItem.Name = "scale50PerToolStripMenuItem";
			this.scale50PerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.scale50PerToolStripMenuItem.Text = "50%";
			// 
			// scale75PerToolStripMenuItem
			// 
			this.scale75PerToolStripMenuItem.Name = "scale75PerToolStripMenuItem";
			this.scale75PerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.scale75PerToolStripMenuItem.Text = "75%";
			// 
			// scale100PerToolStripMenuItem
			// 
			this.scale100PerToolStripMenuItem.Name = "scale100PerToolStripMenuItem";
			this.scale100PerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.scale100PerToolStripMenuItem.Text = "100%";
			// 
			// scale150PerToolStripMenuItem
			// 
			this.scale150PerToolStripMenuItem.Name = "scale150PerToolStripMenuItem";
			this.scale150PerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.scale150PerToolStripMenuItem.Text = "150%";
			// 
			// scale200PerToolStripMenuItem
			// 
			this.scale200PerToolStripMenuItem.Name = "scale200PerToolStripMenuItem";
			this.scale200PerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.scale200PerToolStripMenuItem.Text = "200%";
			// 
			// sizeToolStripSeparator
			// 
			this.sizeToolStripSeparator.Name = "sizeToolStripSeparator";
			this.sizeToolStripSeparator.Size = new System.Drawing.Size(149, 6);
			// 
			// size160x120ToolStripMenuItem
			// 
			this.size160x120ToolStripMenuItem.Name = "size160x120ToolStripMenuItem";
			this.size160x120ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.size160x120ToolStripMenuItem.Text = "160 x 120";
			// 
			// size320x240ToolStripMenuItem
			// 
			this.size320x240ToolStripMenuItem.Name = "size320x240ToolStripMenuItem";
			this.size320x240ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.size320x240ToolStripMenuItem.Text = "320 x 240";
			// 
			// size480x360ToolStripMenuItem
			// 
			this.size480x360ToolStripMenuItem.Name = "size480x360ToolStripMenuItem";
			this.size480x360ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.size480x360ToolStripMenuItem.Text = "480 x 360";
			// 
			// size640x480ToolStripMenuItem
			// 
			this.size640x480ToolStripMenuItem.Name = "size640x480ToolStripMenuItem";
			this.size640x480ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.size640x480ToolStripMenuItem.Text = "640 x 480";
			// 
			// size800x600ToolStripMenuItem
			// 
			this.size800x600ToolStripMenuItem.Name = "size800x600ToolStripMenuItem";
			this.size800x600ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.size800x600ToolStripMenuItem.Text = "800 x 600";
			// 
			// wmpMenuToolStripMenuItem
			// 
			this.wmpMenuToolStripMenuItem.Name = "wmpMenuToolStripMenuItem";
			this.wmpMenuToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.wmpMenuToolStripMenuItem.Text = "WMPメニュー";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.settingToolStripMenuItem.Text = "設定";
			// 
			// PlayerView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(480, 379);
			this.ControlBox = false;
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.pecaPlayer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PlayerView";
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PecaPlayerControl pecaPlayer;
		private StatusBarControl statusBar;
		private ToolStripEx toolStrip;
		private System.Windows.Forms.ToolStripButton minToolStripButton;
		private System.Windows.Forms.ToolStripButton maxToolStripButton;
		private System.Windows.Forms.ToolStripButton closeToolStripButton;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wmpMenuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scale50PerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scale75PerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scale100PerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scale150PerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scale200PerToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator sizeToolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem size160x120ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem size320x240ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem size480x360ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem size640x480ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem size800x600ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}

