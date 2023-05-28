import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Observable, catchError, of } from 'rxjs';
import { AuthenticateService } from 'src/app/service/authenticate.service';
import { UserService } from 'src/app/service/user.service.spec';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  form!: FormGroup;
  constructor(
    private _http:HttpClient
  ) { }

  ngOnInit(): void {
    this._http.get<any>('api/ping/ping').subscribe(x=> console.log(x,9));
    this._http.get<any>('api/ping/ping-anonymous').subscribe(x=> console.log(x,123));
  }



}
