import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class CategoryService {
  constructor(private fb: FormBuilder, private http: HttpClient) {}
  readonly BaseURI = 'http://localhost:5000/api';

  formModel = this.fb.group({
    CategoryName: ['', Validators.required],
  });

  registerCategory() {
    var body = {
      CategoryName: this.formModel.value.CategoryName,
    };
    return this.http.post(this.BaseURI + '/categories', body);
    //return this.http.post(this.BaseURI + '/ApplicationUser/Register', body);
  }
}
