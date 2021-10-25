package com.example.navegador_kotlin

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*
class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        bt.setOnClickListener {
            //obtengo la url
            val direccion=url.text.toString();
            //instancio segunda actividad
            val nav=Intent(this,navegador::class.java)
            //pasamos el parametro
            nav.putExtra("direccion",direccion);
            startActivity(nav);




        }
    }
}