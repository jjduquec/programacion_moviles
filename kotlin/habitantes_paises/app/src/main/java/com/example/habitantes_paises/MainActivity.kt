package com.example.habitantes_paises

import android.os.Bundle
import android.widget.ArrayAdapter
import androidx.appcompat.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val paises = arrayOf( "Argentina", "Chile", "Paraguay", "Bolivia", "Peru", "Ecuador", "Brasil", "Colombia", "Venezuela", "Uruguay")
        var habitantes = arrayOf(40_000_000, 17_000_000, 6_500_000, 10_000_000, 30_000_000, 14_000_000, 183_000_000, 44_000_000, 31_000_000, 3_500_000)
        var adaptador=ArrayAdapter<String>(this,android.R.layout.simple_expandable_list_item_1,paises)
        lista.adapter=adaptador;
        lista.setOnItemClickListener { adapterView, view, i, l ->
            tv.text = "Población de: ${habitantes[i]}"
        }
    }
}