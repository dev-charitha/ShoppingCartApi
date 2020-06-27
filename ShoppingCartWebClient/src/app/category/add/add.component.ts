import { HttpClientModule, HttpClient } from '@angular/common/http'; //remove
import { Component, OnInit } from '@angular/core';
import { CategoryService } from 'src/app/shared/category.service';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styles: [],
})
export class AddComponent implements OnInit {
  constructor(private httpService: HttpClient) {}
  employees: string[];
  ngOnInit() {
    this.httpService
      .get('http://localhost:5000/api/categories') //http://localhost:52202/api/employee
      .subscribe((data) => {
        this.employees = data as string[];
      });
  }
}
//-------------------
//export class AddComponent implements OnInit {
//constructor(public service: CategoryService) {}

// ngOnInit() {
//   this.service.formModel.reset();
// }

//onSubmit() {
//   this.service.registerCategory().subscribe(
//   (res: any) => {
//     if (res.succeded) {
//      this.service.formModel.reset();
//      }
//    },
//      (err) => {}
//   );
//  }
//}
//------------------

//import { HttpClientModule, HttpClient } from '@angular/common/http';
//import { Component, OnInit } from '@angular/core';

//@Component({
// selector: 'app-employee-list',
// templateUrl: './employee-list.component.html',
// styleUrls: ['./employee-list.component.css'],
//})
//export class EmployeeListComponent implements OnInit {
// constructor(private httpService: HttpClient) {}
// employees: string[];
// ngOnInit() {
//    this.httpService
//      .get('http://localhost:52202/api/employee')
//      .subscribe((data) => {
//       this.employees = data as string[];
//     });
// }
//}
