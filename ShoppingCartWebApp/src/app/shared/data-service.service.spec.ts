import { TestBed, inject, async } from '@angular/core/testing';
import { DataServiceService } from './data-service.service';
import { HttpClientModule } from '@angular/common/http';
import {
  HttpTestingController,
  HttpClientTestingModule,
} from '@angular/common/http/testing';

describe('#DataServiceService', () => {
  let service: DataServiceService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [DataServiceService],
    });

    service = TestBed.get(DataServiceService);
    httpMock = TestBed.get(HttpTestingController);
  });

  it(`should fetch products as an Observable`, async(
    inject(
      [HttpTestingController, DataServiceService],
      (httpClient: HttpTestingController, dataService: DataServiceService) => {
        const postItem = [
          {
            id: '1',
            categoryName: 'Computer',
            isActive: 'true',
            createdBy: 'abc123',
            createdDate: '2020-06-22 10:06:24.0866667',
          },
          {
            id: 'tst1',
            categoryName: 'Phone',
            isActive: 'true',
            createdBy: 'abc123',
            createdDate: '2020-06-22 10:06:24.0866667',
          },
        ];

        dataService.loadCategories().subscribe((products: any) => {
          expect(products.length).toBe(2);
        });

        let req = httpMock.expectOne('http://localhost:5000/api/categories');
        expect(req.request.method).toBe('GET');

        req.flush(postItem);
        httpMock.verify();
      }
    )
  ));
});
