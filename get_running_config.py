from ncclient import manager
import os

wlcip = os.environ['WLC_IP']
Username = os.environ['Username']
Pwd = os.environ['Password']

print(wlcip)

with manager.connect(host=wlcip, port=830, username="admin", hostkey_verify=False, password="!enCgrw1166", device_params={'name':'csr'}) as m:

    c = m.get_config(source='running').data_xml

print(c)