//
//  ViewController.swift
//  tip
//
//  Created by Jessica Alexander on 5/22/19.
//  Copyright © 2019 Jessica Alexander. All rights reserved.
//

import UIKit

class ViewController: UIViewController, UIPickerViewDelegate, UIPickerViewDataSource {
    
    @IBOutlet weak var AmountOfBill: UITextField!
    @IBOutlet weak var TipAmount: UILabel!
    @IBOutlet weak var TotalAmount: UILabel!
    @IBOutlet weak var PickerView: UIPickerView!
    @IBOutlet weak var SliderPercent: UISlider!
    @IBOutlet weak var SliderLabel: UILabel!
    @IBOutlet weak var SliderTip: UILabel!
    @IBOutlet weak var SegmentPicker: UISegmentedControl!
    
    let Percent = ["Select Tip Percentage", "5%", "10%", "15%", "20%", "25%"]

    override func viewDidLoad() {
        super.viewDidLoad()
        
        PickerView.delegate = self
        PickerView.dataSource = self
    }
    
    @IBAction func AmountOfBillReturn(_ sender: UITextField) {
        _ = sender.resignFirstResponder()
    }
    
    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
    }
    
    func numberOfComponents(in pickerView: UIPickerView) -> Int {
        return 1
    }
    
    func pickerView(_ pickerView: UIPickerView, numberOfRowsInComponent component: Int) -> Int {
        return Percent.count
    }
    
    func pickerView(_ pickerView: UIPickerView, titleForRow row: Int, forComponent component: Int) -> String? {
        return Percent[row]
    }
    
    func pickerView(_ pickerView: UIPickerView, didSelectRow row: Int, inComponent component: Int) {
        view.endEditing(true)
        let pickedPercent = row
        let billAmt:Double? = Double(AmountOfBill.text!)
        if pickedPercent == 1 {
            TipAmount.text = String(format: "$%.2f", billAmt! * 0.05)
            TotalAmount.text = String(format: "$%.2f", billAmt! * 1.05)
        } else if pickedPercent == 2 {
            TipAmount.text = String(format: "$%.2f", billAmt! * 0.10)
            TotalAmount.text = String(format: "$%.2f", billAmt! * 1.10)
        } else if pickedPercent == 3 {
            TipAmount.text = String(format: "$%.2f", billAmt! * 0.15)
            TotalAmount.text = String(format: "$%.2f", billAmt! * 1.15)
        } else if pickedPercent == 4 {
            TipAmount.text = String(format: "$%.2f", billAmt! * 0.20)
            TotalAmount.text = String(format: "$%.2f", billAmt! * 1.20)
        } else if pickedPercent == 5 {
            TipAmount.text = String(format: "$%.2f", billAmt! * 0.25)
            TotalAmount.text = String(format: "$%.2f", billAmt! * 1.25)
        }
    }
    
    @IBAction func SliderValueChanced(_ sender: UISlider) {
        view.endEditing(true)
        let selectedValue:Int? = Int(sender.value)
        SliderLabel.text = "\(String(describing: selectedValue!))%"
        let tip:Double? = Double(AmountOfBill.text!)! * Double(selectedValue!) / 100
        SliderTip.text = String(format: "tip = $%.2f", tip!)
        TipAmount.text = String(format: "$%.2f", tip!)
        let billAmt:Double? = Double(AmountOfBill.text!)
        TotalAmount.text = String(format: "$%.2f", tip! + billAmt!)
    }
    
    
    @IBAction func SegmentSelected(_ sender: UISegmentedControl) {
        let billAmt:Double? = Double(AmountOfBill.text!)
        switch SegmentPicker.selectedSegmentIndex
        {
        case 0:
            TipAmount.text = String(format: "$%.2f", billAmt! * 0.05)
            TotalAmount.text = String(format: "$%.2f", billAmt! * 1.05)
            break
        case 1:
            TipAmount.text = String(format: "$%.2f", billAmt! * 0.10)
            TotalAmount.text = String(format: "$%.2f", billAmt! * 1.10)
            break
        case 2:
            TipAmount.text = String(format: "$%.2f", billAmt! * 0.15)
            TotalAmount.text = String(format: "$%.2f", billAmt! * 1.15)
            break
        case 3:
            TipAmount.text = String(format: "$%.2f", billAmt! * 0.20)
            TotalAmount.text = String(format: "$%.2f", billAmt! * 1.20)
            break
        case 4:
            TipAmount.text = String(format: "$%.2f", billAmt! * 0.25)
            TotalAmount.text = String(format: "$%.2f", billAmt! * 1.25)
            break
        default:
            break
        }
    }
    
    override func touchesBegan(_ touches: Set<UITouch>, with event: UIEvent?) {
        AmountOfBill.endEditing(true)
    }
}

