package com.example.almacenamiento2

import androidx.appcompat.app.AppCompatActivity
import android.app.Activity
import android.os.Bundle
import android.widget.Toast

import kotlinx.android.synthetic.main.activity_main.*;
import java.io.BufferedReader
import java.io.IOException
import java.io.InputStreamReader
import java.io.OutputStreamWriter


class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        boton1.setOnClickListener {
            val nomarchivo = et1.text.toString().replace('/','-')
            try {
                val archivo = OutputStreamWriter(openFileOutput(nomarchivo, Activity.MODE_PRIVATE))
                archivo.write(et2.text.toString())
                archivo.flush()
                archivo.close()
            } catch (e: IOException) {
            }
            Toast.makeText(this, "Los datos fueron grabados", Toast.LENGTH_SHORT).show()
            et1.setText("")
            et2.setText("")
        }


        boton2.setOnClickListener {
            var nomarchivo = et1.text.toString().replace('/', '-')
            if (fileList().contains(nomarchivo)) {
                try {
                    val archivo = InputStreamReader(openFileInput(nomarchivo))
                    val br = BufferedReader(archivo)
                    var linea = br.readLine()
                    val todo = StringBuilder()
                    while (linea != null) {
                        todo.append(linea + "\n")
                        linea = br.readLine()
                    }
                    br.close()
                    archivo.close()
                    et2.setText(todo)
                } catch (e: IOException) {
                }
            } else {
                Toast.makeText(this, "No hay datos grabados para dicha fecha", Toast.LENGTH_LONG).show()
                et2.setText("")
            }
        }
    }
}