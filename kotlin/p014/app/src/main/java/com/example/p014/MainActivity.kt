package com.example.p014

import android.content.Context
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*
class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        var preferencias=getSharedPreferences("agenda", Context.MODE_PRIVATE);

        bt_guardar.setOnClickListener{
            //guardamos los datos
            var editor=preferencias.edit();
            editor.putString(nombre_vw.text.toString(),detalles_vw.text.toString());
            editor.commit();
            Toast.makeText(this,"Se han almacenado los datos",Toast.LENGTH_LONG);
            nombre_vw.setText("");
            detalles_vw.setText("");



        }

        bt_recuperar.setOnClickListener {
            val datos=preferencias.getString(nombre_vw.text.toString(),"");

            if(datos==""){
                Toast.makeText(this,"No existen datos",Toast.LENGTH_LONG);


            }else{
                detalles_vw.setText(datos);



            }



        }

    }
}