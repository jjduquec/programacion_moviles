package com.example.navegador_kotlin

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.webkit.WebView
import android.webkit.WebViewClient

import kotlinx.android.synthetic.main.activity_navegador.*
class navegador : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_navegador)

        //obtenemos los parametros

        val bundle = intent.extras
        val dir=bundle?.getString("direccion")
        val navegador=findViewById<WebView>(R.id.nav)
        navegador.loadUrl("https://${dir}")
        navegador.webViewClient=object:WebViewClient(){


        }







        bt2.setOnClickListener {

            finish()

        }



    }
}