package com.example.sample_app1

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        tapHere.setOnClickListener {
            if (textView.text == "ちわ！アンドロイド") {
                textView.text = "ボタンがタップされました"
            } else {
                textView.text = "ちわ！アンドロイド"
            }
        }
    }
}
