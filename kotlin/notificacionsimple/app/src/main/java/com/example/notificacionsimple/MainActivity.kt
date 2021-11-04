package com.example.notificacionsimple

import android.content.Context
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast

import kotlinx.android.synthetic.main.activity_main.*


class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        //declaracion de variables
        val preferencias=getSharedPreferences("puntos",Context.MODE_PRIVATE);
        //puntos por defecto
        var editor=preferencias.edit();
        editor.putInt("puntuacion",0);
        editor.commit()
        var puntuacion_actual=preferencias.getInt("puntuacion",0);
        //programamos los puntos aleatorios
        var numeroAleatorio=(Math.random() * 100_001).toInt()
        Toast.makeText(this, "Memoriza este numero: ${numeroAleatorio}", Toast.LENGTH_LONG).show()




        bt.setOnClickListener {
            //obtenemos el numero
            if(numeroAleatorio==numero.text.toString().toInt()){
                Toast.makeText(this, "CORRECTO!", Toast.LENGTH_LONG).show()

                puntuacion_actual+=5
                puntuacion_vw.setText("Puntuacion:${puntuacion_actual}")
                editor.putInt("puntuacion",puntuacion_actual)
                editor.commit()
                numero.setText("");

            }else{

                Toast.makeText(this, "Ups! Te equivocaste", Toast.LENGTH_LONG).show()
                puntuacion_actual-=5
                puntuacion_vw.setText("Puntuacion:${puntuacion_actual}")
                editor.putInt("puntuacion",puntuacion_actual)
                editor.commit()
                numero.setText("");
            }

        }


        bt_jugar.setOnClickListener {
            numeroAleatorio=(Math.random() * 100_001).toInt()
            Toast.makeText(this, "Memoriza este numero: ${numeroAleatorio}", Toast.LENGTH_LONG).show()
            numero.setText("");


        }


    }
}