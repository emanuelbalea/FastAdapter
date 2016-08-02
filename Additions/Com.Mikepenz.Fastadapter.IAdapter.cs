using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']"
	[Register ("com/mikepenz/fastadapter/IAdapter", "", "Com.Mikepenz.Fastadapter.IAdapterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Item extends com.mikepenz.fastadapter.IItem"})]
	public partial interface IAdapter : IJavaObject {

		int AdapterItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']/method[@name='getAdapterItemCount' and count(parameter)=0]"
			[Register ("getAdapterItemCount", "()I", "GetGetAdapterItemCountHandler:Com.Mikepenz.Fastadapter.IAdapterInvoker, FastAdapter")] get;
		}

		global::System.Collections.IList AdapterItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']/method[@name='getAdapterItems' and count(parameter)=0]"
			[Register ("getAdapterItems", "()Ljava/util/List;", "GetGetAdapterItemsHandler:Com.Mikepenz.Fastadapter.IAdapterInvoker, FastAdapter")] get;
		}

		global::Com.Mikepenz.Fastadapter.FastAdapter FastAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']/method[@name='getFastAdapter' and count(parameter)=0]"
			[Register ("getFastAdapter", "()Lcom/mikepenz/fastadapter/FastAdapter;", "GetGetFastAdapterHandler:Com.Mikepenz.Fastadapter.IAdapterInvoker, FastAdapter")] get;
		}

		int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()I", "GetGetItemCountHandler:Com.Mikepenz.Fastadapter.IAdapterInvoker, FastAdapter")] get;
		}

		int Order {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']/method[@name='getOrder' and count(parameter)=0]"
			[Register ("getOrder", "()I", "GetGetOrderHandler:Com.Mikepenz.Fastadapter.IAdapterInvoker, FastAdapter")] get;
		}

		//// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']/method[@name='getAdapterItem' and count(parameter)=1 and parameter[1][@type='int']]"
		//[Register ("getAdapterItem", "(I)Lcom/mikepenz/fastadapter/IItem;", "GetGetAdapterItem_IHandler:Com.Mikepenz.Fastadapter.IAdapterInvoker, FastAdapter")]
		//global::Java.Lang.Object GetAdapterItem (int p0);

		//// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']/method[@name='getAdapterPosition' and count(parameter)=1 and parameter[1][@type='Item']]"
		//[Register ("getAdapterPosition", "(Lcom/mikepenz/fastadapter/IItem;)I", "GetGetAdapterPosition_Lcom_mikepenz_fastadapter_IItem_Handler:Com.Mikepenz.Fastadapter.IAdapterInvoker, FastAdapter")]
		//int GetAdapterPosition (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']/method[@name='getGlobalPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getGlobalPosition", "(I)I", "GetGetGlobalPosition_IHandler:Com.Mikepenz.Fastadapter.IAdapterInvoker, FastAdapter")]
		int GetGlobalPosition (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lcom/mikepenz/fastadapter/IItem;", "GetGetItem_IHandler:Com.Mikepenz.Fastadapter.IAdapterInvoker, FastAdapter")]
		global::Java.Lang.Object GetItem (int p0);

	}

}
