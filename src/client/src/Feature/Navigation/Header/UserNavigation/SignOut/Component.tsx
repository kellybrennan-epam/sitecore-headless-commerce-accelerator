//    Copyright 2020 EPAM Systems, Inc.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

import * as JSS from 'Foundation/ReactJss';
import * as React from 'react';

import { Button, NavigationLink } from 'Foundation/UI';

import { LoadingStatus } from 'Foundation/Integration';

import { SignOutProps } from './models';
import './styles.scss';

export class SignOutComponent extends JSS.SafePureComponent<SignOutProps, {}> {
  protected safeRender() {
    const { Logout, logoutProcess, returnUrl, onLoaded } = this.props;

    if (logoutProcess.status === LoadingStatus.Loaded && onLoaded) {
      onLoaded();
    }

    return (
      <div className="form-sign-out">
        <NavigationLink className="btn btn-main" to="/account">
          <JSS.Text tag="span" field={{ value: 'My Account', editable: 'My Account' }} />
        </NavigationLink>
        <NavigationLink className="btn btn-main" to="/account/order-history">
          <JSS.Text tag="span" field={{ value: 'Order History', editable: 'Order History' }} />
        </NavigationLink>
        <hr />
        <Button className="btn btn-focus" onClick={() => Logout(returnUrl)} buttonText="Sugn out" />
      </div>
    );
  }
}
