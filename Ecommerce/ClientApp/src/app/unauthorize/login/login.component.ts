import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Observable, catchError, of } from 'rxjs';
import { AuthenticateService } from 'src/app/service/authenticate.service';
import { UserService } from 'src/app/service/user.service.spec';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  form!: FormGroup;
  constructor(
    private _fb: FormBuilder,
    private _userService: UserService,
    private _auth:AuthenticateService,
    private _router:Router
  ) { }

  ngOnInit(): void {
    this.initForm();
  }

  login(){
    const username = this.form.get('username')?.value
    const password = this.form.get('password')?.value
    this._userService.login(username,password).subscribe((res)=>{
      if(res.token.length > 0){
        this._auth.persistToken(res.token);
        this._router.navigate(['home'])

      }
    })
  }

  initForm(): void {
    this.form = this._fb.group({
      username: ["", [Validators.required]],
      password: ["", [Validators.required]],
    });
  }

}
