import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  gridForm: FormGroup;
  default_rows    = 3;
  default_columns = 3;

  loading = false;

  constructor(private fb: FormBuilder) {
    
    this.gridForm = this.fb.group({
      rows:     [this.default_rows,     [Validators.pattern("^[0-9]*$")]],
      columns:  [this.default_columns,  [Validators.pattern("^[0-9]*$")]]
    });
  }

  // Init before rendering visuals
  ngOnInit(): void {
  }

  increaseRows() {
    this.loading = true;
    this.default_rows = +this.gridForm.value.rows;
    this.loading = false;
  }

  increaseColumns() {
    this.loading = true;
    this.default_columns = +this.gridForm.value.columns;
    this.loading = false;
  }
}

