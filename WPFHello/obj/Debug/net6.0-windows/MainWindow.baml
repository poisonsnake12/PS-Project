   M S B A M L   `   `   `  ����C  ?WPFHello, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPFHelloWPFHello  5   	       WPFHello.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPFHello     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��93* �6   �� 5      $��7* �6   .+�5   
   �� -   5         ��Name$ Hello_World��5      $��Hello, WPF!
��6%   $
��Left=�6@   $��50��6[   $��	10,10,0,0q�6g   $	��Top=�6z   $	��190��6�   $	��28 (�6�   $
��Bold"�5      �� 5   
   -   5         ��Name$ btnHello��5      $��Здрасти!��6#   $
��Left=�66   $��34��6Q   $��100,109,0,0q�6]   $	��Top=�6r   $	��100��6�   $��16(�6�   6�   �� 5   
   -   5        $ lblName��5      $��Име:��6!   $
��Left=�60   $��39��6K   $��	10,65,0,0q�6W   $	��Top=�6j   $��55��6�   $��18(�6�   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��30��6>   $��	65,69,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��135��6�   $��18(�6�   �� 5   
   -   5         ��Name$ gbUser��5      $
��Left=�6#   $	��171��6>   $
��Name��6K   $	��Top=�6Y   $	��226��6q   $��0,-1,0,0q�6}   �� 5   
   -   5         ��Name$ peopleListBox��5      $��664,20,20,285q�6T   $��2��6k   �� 5   
   -   5        $ btnHighligthed_Click��5      $��Избран Човек��6/   $
��Left=�6F   $��34��6a   $��664,170,0,0q�6m   $	��Top=�6�   $	��116��6�   $��16(�6�   $��2��6�   5      5      